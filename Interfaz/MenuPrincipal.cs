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
        private DateTime hora;
        public MenuPrincipal(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            MensajeDeBarraDeInformacion(usuarioActual.NombreDeUsuario);
            IsMdiContainer = true;
            hora = DateTime.Now;

        }
        public Usuario UsuarioActual
        {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.horaToolStripMenuItem.Text = $"Hora: {DateTime.Now.ToString("HH:mm:ss")}";
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

        private void horaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (horaToolStripMenuItem.Checked)
            {
                timer1.Enabled = true;
                this.horaToolStripMenuItem.Text = $"Hora: {DateTime.Now.ToString("HH:mm:ss")}";
            }
            else
            {
                timer1.Enabled = false;
                this.horaToolStripMenuItem.Text = $"Hora";
            }
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
                horaToolStripMenuItem.ForeColor = Color.LightGray;
                //mnu_menuPrincipal.BackgroundImage = imageList1.Images[1];
                //mnu_menuPrincipal.BackgroundImageLayout = ImageLayout.Tile;
                //pnl_barraInfo.BackgroundImage = imageList1.Images[1];
                //pnl_barraInfo.BackgroundImageLayout = ImageLayout.Tile;

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
                horaToolStripMenuItem.ForeColor = Color.Black;
                cerrarSecionToolStripMenuItem.ForeColor = Color.Black;
                //mnu_menuPrincipal.BackgroundImage = imageList1.Images[0];
                //mnu_menuPrincipal.BackgroundImageLayout = ImageLayout.Tile;
                //pnl_barraInfo.BackgroundImage = imageList1.Images[0];
                //pnl_barraInfo.BackgroundImageLayout = ImageLayout.Tile;
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

    }
}
