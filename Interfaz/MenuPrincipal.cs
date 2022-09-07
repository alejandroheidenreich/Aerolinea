using Entidades;
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
    public partial class MenuPrincipal : Form
    {

        private Usuario usuarioActual;
        public MenuPrincipal()
        {
            InitializeComponent();

        }
        public Usuario UsuarioActual
        {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }
        private void planDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeVuelos listaDeVuelos = new ListaDeVuelos();
            this.Hide();
            listaDeVuelos.ShowDialog();
        }

        private void ventaDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaDeVuelos ventaDeVuelos = new VentaDeVuelos();
            this.Hide();
            ventaDeVuelos.ShowDialog();
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.ShowDialog();
        }
    }
}
