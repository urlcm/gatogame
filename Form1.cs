namespace GatoGame
{
    public partial class Form1 : Form
    {
        private PictureBox[,] botones;
        private static int contador = 0;
        ClaseGato juegoGato;
        private Image X = Properties.Resources.perrito_te_quiero_mucho_removebg_preview;
        private Image O = Properties.Resources.gwar_removebg_preview;
        private Image Humano;
        private Image Maquina;

        public Form1()
        {
            InitializeComponent();
            botones = new PictureBox[3, 3];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IngresarBotones();
            BloquearBotones();
            BloquearBotonReiniciarPartida();
        }

        private void IngresarBotones()
        {
            botones[0, 0] = this.pictureBox1;
            botones[0, 1] = this.pictureBox2;
            botones[0, 2] = this.pictureBox3;
            botones[1, 0] = this.pictureBox4;
            botones[1, 1] = this.pictureBox5;
            botones[1, 2] = this.pictureBox6;
            botones[2, 0] = this.pictureBox7;
            botones[2, 1] = this.pictureBox8;
            botones[2, 2] = this.pictureBox9;
        }

        public void BloquearBotones()
        {
            for (int i = 0; i < ClaseGato.TAMANO; i++)
            {
                for (int j = 0; j < ClaseGato.TAMANO; j++)
                {
                    this.botones[i, j].Enabled = false;
                }
            }
        }

        public void DesbloquearBotones()
        {
            for (int i = 0; i < ClaseGato.TAMANO; i++)
            {
                for (int j = 0; j < ClaseGato.TAMANO; j++)
                {
                    this.botones[i, j].Enabled = true;
                }
            }
        }

        private void bntEmpezarPartida_Click(object sender, EventArgs e)
        {
            juegoGato = new ClaseGato();
            DesbloquearBotones();
            LimpiarCasillas();
            this.lblGanador.Text = "El ganador es: ";
            this.btnEmpezarPartida.Text = "Reiniciar Partida";
            Form1.contador = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(0, 0);
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(0, 1);
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(0, 2);
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(1, 0);
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(1, 1);
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(1, 2);
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(2, 0);
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(2, 1);
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            juegoGato.PulsarBoton(2, 2);
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Image = Humano;
            this.MarcarCasillaMaquina();
            Form1.contador++;
        }

        private void btnFiguraX_Click(object sender, EventArgs e)
        {
            this.Humano = this.X;
            this.Maquina = this.O;
            this.btnEmpezarPartida.Enabled = true;
            this.BloquearBotonesX_O();
        }

        private void btnFiguraO_Click(object sender, EventArgs e)
        {
            this.Humano = this.O;
            this.Maquina = this.X;
            this.btnEmpezarPartida.Enabled = true;
            this.BloquearBotonesX_O();
        }

        private void BloquearBotonesX_O()
        {
            this.btnFiguraX.Enabled = false;
            this.btnFiguraO.Enabled = false;
        }

        private void DesbloquearBotonesX_O()
        {
            this.btnFiguraX.Enabled = true;
            this.btnFiguraO.Enabled = true;
        }

        private void MarcarCasillaMaquina()
        {
            int[,] tablero = juegoGato.obtenerTablero;
            for (int i = 0; i < ClaseGato.TAMANO; i++)
            {
                for (int j = 0; j < ClaseGato.TAMANO; j++)
                {
                    if (tablero[i, j] == 1)
                    {
                        this.botones[i, j].Enabled = false;
                        this.botones[i, j].Image = this.Maquina;
                    }
                }
            }
            Ganador();
        }

        private void LimpiarCasillas()
        {
            for (int i = 0; i < ClaseGato.TAMANO; i++)
            {
                for (int j = 0; j < ClaseGato.TAMANO; j++)
                {
                    this.botones[i, j].Image = default;
                }
            }
        }

        private void BloquearBotonReiniciarPartida()
        {
            this.btnEmpezarPartida.Enabled = false;
        }

        public void Ganador()
        {
            if (juegoGato.obtenerGanador == 0)
            {
                this.lblGanador.Text += "El Humano";
                BloquearBotones();
                DesbloquearBotonesX_O();
                BloquearBotonReiniciarPartida();
            }
            else if (juegoGato.obtenerGanador == 1)
            {
                this.lblGanador.Text += "La máquina";
                BloquearBotones();
                DesbloquearBotonesX_O();
                BloquearBotonReiniciarPartida();
            }
            else if (juegoGato.obtenerGanador == -1 && contador == 4)
            {
                this.lblGanador.Text = "No hay ganador. Empate";
                BloquearBotones();
                DesbloquearBotonesX_O();
                BloquearBotonReiniciarPartida();
            }
        }
    }
}
