using Entidades;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario usuarioActual;
        private Form? formActivo;
        public FrmMenuPrincipal(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            MensajeDeBarraDeInformacion(usuarioActual.NombreDeUsuario);
            IsMdiContainer = true;
        }
        public Usuario UsuarioActual
        {
            get
            {
                return usuarioActual;
            }
            set
            {
                usuarioActual = value;
            }
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
            FrmLogIn login = new FrmLogIn();
            this.Hide();
            login.ShowDialog();
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarForm();
            pnl_PanelDeFondo.Visible = true;
        }

        private void InformacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmInformacionDeLosPasajeros(btn_ToggleTema.Checked));
        }

        private void ListaDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmAdministracionDeVuelos(btn_ToggleTema.Checked));
        }

        private void VentaDeVuelosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            ActivarForm(new FrmVentaDeVuelos(btn_ToggleTema.Checked));
        }

        private void ActivarForm(Form form)
        {
            OcultarForm();
            formActivo = form;
            formActivo.MdiParent = this;
            pnl_PanelDeFondo.Visible = false;
            formActivo.Show();
        }

        private void OcultarForm()
        {
            if (formActivo is not null)
            {
                formActivo.Hide();
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
                Reloj.Enabled = true;
                this.horaToolStripMenuItem.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                Reloj.Enabled = false;
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
                ActivarDarkMode();
                RecargarForm();
            }
            else
            {
                ActivarLightMode();
                RecargarForm();
            }
        }
        private void RecargarForm()
        {
            if (this.formActivo is not null)
            {
                this.formActivo.Refresh();
            }
        }
        private void ActivarDarkMode()
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
        private void ActivarLightMode()
        {
            BackColor = Color.WhiteSmoke;
            pnl_barraInfo.BackColor = Color.SkyBlue;
            mnu_menuPrincipal.BackColor = Color.SkyBlue;
            lbl_InfoUsuarioFecha.ForeColor = Color.Black;
            inicioToolStripMenuItem.ForeColor = Color.Black;
            clientesToolStripMenuItem1.ForeColor = Color.Black;
            vuelosToolStripMenuItem.ForeColor = Color.Black;
            cuentaToolStripMenuItem.ForeColor = Color.Black;
            cerrarToolStripMenuItem.ForeColor = Color.Black;
            horaToolStripMenuItem.ForeColor = Color.Black;
            cerrarSecionToolStripMenuItem.ForeColor = Color.Black;
        }
    }
}
