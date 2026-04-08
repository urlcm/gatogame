namespace GatoGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnFiguraX = new Button();
            btnFiguraO = new Button();
            btnEmpezarPartida = new Button();
            lblGanador = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 26);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 9;
            label1.Text = "Juego del gato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(495, 57);
            label2.Name = "label2";
            label2.Size = new Size(189, 19);
            label2.TabIndex = 10;
            label2.Text = "Selecciona tu figura";
            // 
            // btnFiguraX
            // 
            btnFiguraX.Image = Properties.Resources.perrito_te_quiero_mucho_removebg_preview;
            btnFiguraX.Location = new Point(428, 111);
            btnFiguraX.Margin = new Padding(3, 2, 3, 2);
            btnFiguraX.Name = "btnFiguraX";
            btnFiguraX.Size = new Size(149, 122);
            btnFiguraX.TabIndex = 11;
            btnFiguraX.UseVisualStyleBackColor = true;
            btnFiguraX.Click += btnFiguraX_Click;
            // 
            // btnFiguraO
            // 
            btnFiguraO.Image = Properties.Resources.gwar_removebg_preview;
            btnFiguraO.ImageAlign = ContentAlignment.MiddleRight;
            btnFiguraO.Location = new Point(593, 111);
            btnFiguraO.Margin = new Padding(3, 2, 3, 2);
            btnFiguraO.Name = "btnFiguraO";
            btnFiguraO.Size = new Size(157, 122);
            btnFiguraO.TabIndex = 12;
            btnFiguraO.TextAlign = ContentAlignment.MiddleRight;
            btnFiguraO.UseVisualStyleBackColor = true;
            btnFiguraO.Click += btnFiguraO_Click;
            // 
            // btnEmpezarPartida
            // 
            btnEmpezarPartida.Location = new Point(480, 255);
            btnEmpezarPartida.Margin = new Padding(3, 2, 3, 2);
            btnEmpezarPartida.Name = "btnEmpezarPartida";
            btnEmpezarPartida.Size = new Size(187, 69);
            btnEmpezarPartida.TabIndex = 13;
            btnEmpezarPartida.Text = "Iniciar partida";
            btnEmpezarPartida.UseVisualStyleBackColor = true;
            btnEmpezarPartida.Click += bntEmpezarPartida_Click;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanador.Location = new Point(279, 367);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(170, 22);
            lblGanador.TabIndex = 14;
            lblGanador.Text = "El ganador es : ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(40, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(160, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(279, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(41, 172);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(107, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += button4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(160, 172);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(107, 85);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += button5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Location = new Point(279, 172);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(107, 85);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            pictureBox6.Click += button6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.Location = new Point(41, 265);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(107, 85);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 21;
            pictureBox7.TabStop = false;
            pictureBox7.Click += button7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.Location = new Point(160, 265);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(107, 85);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            pictureBox8.Click += button8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.Location = new Point(279, 265);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(107, 85);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            pictureBox9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 414);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblGanador);
            Controls.Add(btnEmpezarPartida);
            Controls.Add(btnFiguraO);
            Controls.Add(btnFiguraX);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnFiguraX;
        private Button btnFiguraO;
        private Button btnEmpezarPartida;
        private Label lblGanador;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}
