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
        public Player(PictureBox suaPictureBox) : base(suaPictureBox)
        {
            TemArma = true;
        }
    }
}
