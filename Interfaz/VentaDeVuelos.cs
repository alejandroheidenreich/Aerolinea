﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class VentaDeVuelos : Form
    {
        private Usuario usuarioActual;
        public VentaDeVuelos(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(usuarioActual);
            this.Hide();
            menuPrincipal.ShowDialog();
        }
    }
}