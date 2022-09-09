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
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void Reloj_Tick(object sender, EventArgs e)
        {
            this.horaToolStripMenuItem.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.ShowDialog();
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form hijos = this.ActiveMdiChild;

            while (hijos is not null)
            {
                hijos.Hide();
                hijos = this.ActiveMdiChild;
            }

            pnl_PanelDeFondo.Visible = true;
        }

        private void InformacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }
        private void ListaDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdministracionDeVuelos"] is not null)
            {
                Application.OpenForms["AdministracionDeVuelos"].Activate();    
                Application.OpenForms["AdministracionDeVuelos"].StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                AdministracionDeVuelos administracionDeVuelos = new AdministracionDeVuelos(usuarioActual);
                administracionDeVuelos.MdiParent = this;
                pnl_PanelDeFondo.Visible = false;
                administracionDeVuelos.Show();
            }
        }

        private void VentaDeVuelosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["VentaDeVuelos"] is not null)
            {
                Application.OpenForms["VentaDeVuelos"].Activate();
                Application.OpenForms["VentaDeVuelos"].StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                VentaDeVuelos ventaDeVuelos = new VentaDeVuelos(usuarioActual);
                ventaDeVuelos.MdiParent = this;
                pnl_PanelDeFondo.Visible = false;
                ventaDeVuelos.Show();
            }
        }
        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (horaToolStripMenuItem.Checked)
            {
                timer1.Enabled = true;
                this.horaToolStripMenuItem.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                timer1.Enabled = false;
                this.horaToolStripMenuItem.Text = String.Empty;
            }
        }
        private void MensajeDeBarraDeInformacion(string usuario)
        {
            DateTime fechaDeHoy = DateTime.Now;
            lbl_InfoUsuarioFecha.Text = $"Usuario: {usuario} Fecha: {fechaDeHoy.ToString("dd/MM/yyyy")}";
        }

        private void btn_ToggleCambioDeTema_Checked(object sender, EventArgs e)
        {
            if (btn_ToggleTema.Checked)
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
            }
        } 
    }
}
