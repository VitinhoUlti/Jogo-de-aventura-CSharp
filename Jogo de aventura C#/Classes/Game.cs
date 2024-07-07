using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_aventura_C_.Classes
{
    internal class Game
    {
        private int level = 0;
        private List<PictureBox> TodosOsInimigos;

        public Game(List<PictureBox> todosOsInimigos)
        {
            TodosOsInimigos = todosOsInimigos;
        }

        public void PassarLevel(List<PictureBox> inimigosQueApareceram)
        {
            level++;

            foreach (var item in TodosOsInimigos)
            {
                item.Visible = false;
            }

            foreach (var item in inimigosQueApareceram)
            {
                item.Visible = true;
            }
        }

        public int Level()
        {
            return level;
        }

        public void VoltarLevelAZero()
        {
            level = 0;
        }
    }
}
