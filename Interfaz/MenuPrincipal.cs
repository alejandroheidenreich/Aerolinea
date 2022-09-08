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
using static System.Windows.Forms.DataFormats;

namespace Interfaz
{
    public partial class MenuPrincipal : Form
    {

        private Usuario usuarioActual;
        private VentaDeVuelos ventaDeVuelos;
        public MenuPrincipal(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            MensajeDeBarraDeInformacion(usuarioActual.NombreDeUsuario);
            IsMdiContainer = true;
        }
        public Usuario UsuarioActual
        {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }
        private void ventaDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventaDeVuelos is null)
            {
                ventaDeVuelos = new VentaDeVuelos(usuarioActual);
                ventaDeVuelos.MdiParent = this;
            }
            OcultarFondo();
            ventaDeVuelos.Show();
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.ShowDialog();
        }

        private void MensajeDeBarraDeInformacion(string usuario)
        {
            DateTime fechaDeHoy = DateTime.Now;
            lbl_InfoUsuarioFecha.Text = $"Usuario: {usuario} Fecha: {fechaDeHoy.ToString("dd/MM/yyyy")}";
        }

        private void btn_ToggleTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_ToggleTheme.Checked)
            {
                this.BackColor = Color.Black;
                pnl_barraInfo.BackColor = Color.SteelBlue;
                mnu_menuPrincipal.BackColor = Color.SteelBlue;
                lbl_InfoUsuarioFecha.ForeColor = Color.LightGray;
                inicioToolStripMenuItem.ForeColor = Color.LightGray;
                clientesToolStripMenuItem1.ForeColor = Color.LightGray;
                vuelosToolStripMenuItem.ForeColor = Color.LightGray;
                cuentaToolStripMenuItem.ForeColor = Color.LightGray;
                cerrarToolStripMenuItem.ForeColor = Color.LightGray;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                pnl_barraInfo.BackColor = Color.SkyBlue;
                mnu_menuPrincipal.BackColor = Color.SkyBlue;
                lbl_InfoUsuarioFecha.ForeColor = Color.Black;
                inicioToolStripMenuItem.ForeColor = Color.Black;
                clientesToolStripMenuItem1.ForeColor = Color.Black;
                vuelosToolStripMenuItem.ForeColor = Color.Black;
                cuentaToolStripMenuItem.ForeColor= Color.Black;
                cerrarToolStripMenuItem.ForeColor = Color.Black;
                cerrarSecionToolStripMenuItem.ForeColor = Color.Black;
            }
        }
        private void OcultarFondo()
        {
            pnl_PanelDeFondo.Visible = false;
        }
        private void MostrarFondo()
        {
            pnl_PanelDeFondo.Visible = true;
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFondo();
        }

        private void listaDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeVuelos listaDeVuelos = new ListaDeVuelos(usuarioActual, btn_ToggleTheme.Checked);
            listaDeVuelos.ShowDialog();
        }

        private void informacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ventaDeVuelos is null)
            {
                ventaDeVuelos = new VentaDeVuelos(usuarioActual);
                ventaDeVuelos.MdiParent = this;
            }
            OcultarFondo();
            ventaDeVuelos.Show();
        }

        private void ventaDeVuelosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ventaDeVuelos is null)
            {
                ventaDeVuelos = new VentaDeVuelos(usuarioActual);
                ventaDeVuelos.MdiParent = this;
            }
            OcultarFondo();
            ventaDeVuelos.Show();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
