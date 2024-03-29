using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_aventura_C_.Classes
{
    enum Direção
    {
        Up,
        Down,
        Left,
        Right
    }

    abstract class Objetos
    {
        public PictureBox SuaPictureBox;
        public int Vidas = 3;
        protected Point Localização;
        protected Point RangedeAtaque;
        protected bool TemArma = true;

        public Objetos(PictureBox suaPictureBox)
        {
            SuaPictureBox = suaPictureBox;
            Localização = suaPictureBox.Location;
        }

        public Point Mover(Direção direção)
        {
            VerificarDireção(direção);
            return Localização;
        }
        protected void VerificarDireção(Direção direção)
        {
            switch (direção)
            {
                case Direção.Up:
                    Localização.Y -= 40;
                    break;
                case Direção.Left:
                    Localização.X -= 40;
                    break;
                case Direção.Down:
                    Localização.Y += 40;
                    break;
                case Direção.Right:
                    Localização.X += 40;
                    break;
                default:
                    break;
            }
        }

        public Point VerificarRange(Direção direção)
        {
            Point antigaLocalização = Localização;

            VerificarDireção(direção);
            RangedeAtaque = Localização;

            Localização = antigaLocalização;

            return RangedeAtaque;
        }

        public void Atacar(Objetos inimigo)
        {
            if (TemArma && SuaPictureBox.Visible)
            {
                TirarVida(inimigo);
            }
        }
        public void TirarVida(Objetos inimigo)
        {
            if (inimigo.SuaPictureBox.Visible)
            {
                inimigo.Vidas--;
            }
            if (inimigo.Vidas < 1)
            {
                inimigo.SuaPictureBox.Visible = false;
            }
        }
    }
}
