using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_aventura_C_.Classes
{
    internal class Player : Objetos
    {
        public Player(PictureBox suaPictureBox, int casasQueAnda) : base(suaPictureBox, casasQueAnda)
        {
            TemArma = false;
        }

        public void PegarItem(Armas arma)
        {
            arma.SuaPictureBox.Visible = false;
            arma.FotoNoInventario.Visible = true;
        }
        public void VerificarSeArmaCausaDano(Armas arma)
        {
            if (arma.CausaDano)
            {
                TemArma = true;
            }
            else
            {
                TemArma = false;
            }
        }

        public Point VoltarAoPontoOriginal()
        {
            Localização = new Point(485, 142);
            return Localização;
        }

        public void UsarPoção(int VidasRecuperadas)
        {
            Vidas += VidasRecuperadas;
        }

        public override void TirarVida(Objetos inimigo)
        {
            if (inimigo.SuaPictureBox.Visible)
            {
                inimigo.Vidas -= DanoDaArma;
            }

            if (inimigo.Vidas < 1)
            {
                inimigo.SuaPictureBox.Visible = false;
            }
        }
        public void MudarDanoDaArma(int dano)
        {
            DanoDaArma = dano;
        }
    }
}
