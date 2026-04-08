using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoGame
{
    public class ClaseGato
    {
        public static int TAMANO = 3;
        private int[,] tablero = new int[TAMANO, TAMANO];
        private int ganador = -1;

        public ClaseGato() 
        {
            EmpezarPartida();
        } 

        public int[,] obtenerTablero
        {
            get => this.tablero;
        }

        public int obtenerGanador
        {
            get => this.ganador;
        }

        private void EmpezarPartida()
        {
            for (int fila = 0; fila < ClaseGato.TAMANO; fila++)
            {
                for (int col = 0; col < ClaseGato.TAMANO; col++)
                {
                    this.tablero[fila, col] = -1;
                }
            }
            this.ganador = -1;
        }

        public void PulsarBoton(int fila, int col)
        {
            if (fila >= 0 && fila < ClaseGato.TAMANO && col < ClaseGato.TAMANO && this.tablero[fila, col] != 1)
            {
                if (this.ganador == -1)
                {
                    this.tablero[fila, col] = 0;
                    this.ganador++;
                    PonerFichaOrdenador();
                }
            }
        }

        public int GanaPartida()
        {
            if (this.tablero[0, 0] != -1 && this.tablero[0, 0] == this.tablero[1, 1]
                && this.tablero[0, 0] == this.tablero[2, 2])
                return this.tablero[0, 0];

            if (this.tablero[0, 2] != -1 && this.tablero[0, 2] == this.tablero[1, 1]
                && this.tablero[0, 2] == tablero[2, 0])
                return tablero[0, 2];

            for (int i = 0; i < TAMANO; i++)
            {
                if (this.tablero[i, 0] != -1 && this.tablero[i, 0] == this.tablero[i, 1]
                    && this.tablero[i, 0] == this.tablero[i, 2])
                    return this.tablero[i, 0];

                if (this.tablero[0, i] != -1 && this.tablero[0, i] == this.tablero[1, i]
                    && this.tablero[0, i] == tablero[2, i])
                    return tablero[0, i];
            }

            return -1;
        }

        //Algoritmo minimax
        private bool TableroCompleto()
        {
            for (int i = 0; i < ClaseGato.TAMANO; i++)
            {
                for (int m = 0; m < ClaseGato.TAMANO; m++)
                {
                    if (this.tablero[i, m] == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool FinPartida()
        {
            return TableroCompleto() || (GanaPartida() != -1);
        }

        private void PonerFichaOrdenador()
        {
            if (!FinPartida())
            {
                int f = 0, c = 0;
                int valorMinimo = int.MinValue;
                int aux;

                for (int i = 0; i < ClaseGato.TAMANO; i++)
                {
                    for (int j = 0; j < ClaseGato.TAMANO; j++)
                    {
                        if (tablero[i, j] == -1)
                        {
                            this.tablero[i, j] = 1;
                            aux = min();
                            if (aux > valorMinimo)
                            {
                                valorMinimo = aux;
                                f = i;
                                c = j;
                            }
                            this.tablero[i, j] = -1;
                        }
                    }
                }
                this.tablero[f, c] = 1;
            }
            ganador = GanaPartida();
        }

        private int max()
        {
            if (FinPartida())
            {
                if (GanaPartida() != -1) return -1;
                else return 0;
            }

            int valorMinimo = int.MinValue;
            int aux;
            for (int n = 0; n < ClaseGato.TAMANO; n++)
            {
                for (int m = 0; m < ClaseGato.TAMANO; m++)
                {
                    if (tablero[n, m] == -1)
                    {
                        this.tablero[n, m] = 1;
                        aux = min();
                        if (aux > valorMinimo)
                        {
                            valorMinimo = aux;
                        }
                        tablero[n, m] = -1;
                    }
                }
            }
            return valorMinimo;
        }

        private int min()
        {
            if (FinPartida())
            {
                if (GanaPartida() != -1) return 1;
                else return 0;
            }

            int valorMax = int.MaxValue;
            int aux;
            for (int n = 0; n < ClaseGato.TAMANO; n++)
            {
                for (int m = 0; m < ClaseGato.TAMANO; m++)
                {
                    if (this.tablero[n, m] == -1)
                    {
                        this.tablero[n, m] = 0;
                        aux = max();
                        if (aux < valorMax)
                        {
                            valorMax = aux;
                        }
                        this.tablero[n, m] = -1;
                    }
                }
            }
            return valorMax;
        }

        //fin algoritmo minimax

    }
}
