﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class VentaDeVuelos : Form
    {
        public VentaDeVuelos(bool temaActual)
        {
            InitializeComponent();
            TemaActual(temaActual);
        }

        private void TemaActual(bool temaActual)
        {
            if (temaActual)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }

    }
}
