﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_aventura_C_.Classes
{
    internal class Armas : Objetos
    {
        public bool CausaDano;
        public PictureBox FotoNoInventario;

        public Armas(PictureBox suaPictureBox, PictureBox fotoNoInventario, bool causaDano) : base(suaPictureBox, 0)
        {
            CausaDano = causaDano;
            FotoNoInventario = fotoNoInventario;
        }
    }
}
