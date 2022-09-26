using Entidades;
using Interfaz.FrmCuenta;
using System;
using System.Drawing;
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
            MensajeDeBarraDeInformacion(usuarioActual);
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            ActivarDarkMode();
        }
        private void Reloj_Tick(object sender, EventArgs e)
        {
            this.horaToolStripMenuItem.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmLogIn login = new FrmLogIn();
                this.Hide();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo el siguiente error: {ex.Message}");
                Application.Exit();
            }
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarForm();
            pnl_PanelDeFondo.Visible = true;
            this.btn_ToggleTema.Visible = true;
            this.lbl_DarkTheme.Visible = true;
        }

        private void InformacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmInformacionDeLosClientes(btn_ToggleTema.Checked));
        }

        private void ListaDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmAdministracionDeVuelos(btn_ToggleTema.Checked));
        }

        private void configurarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmConfiguracionCuenta(this.usuarioActual,btn_ToggleTema.Checked));
        }
        private void estadisticasHistoricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmEstadisitcasHistoricas(btn_ToggleTema.Checked));
        }
        private void ActivarForm(Form form)
        {
            OcultarForm();
            formActivo = form;
            formActivo.MdiParent = this;
            pnl_PanelDeFondo.Visible = false;
            this.btn_ToggleTema.Visible = false;
            this.lbl_DarkTheme.Visible = false;
            formActivo.Show();
        }

        private void OcultarForm()
        {
            if (formActivo is not null)
            {
                formActivo.Close();
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
        private void MensajeDeBarraDeInformacion(Usuario usuario)
        {
            DateTime fechaDeHoy = DateTime.Now;
            lbl_InfoUsuarioFecha.Text = $"{usuario.Nombre} {usuario.Apellido} Fecha: {fechaDeHoy.ToString("dd/MM/yyyy")}";
        }

        private void btn_ToggleCambioDeTema_Checked(object sender, EventArgs e)
        {
            if (btn_ToggleTema.Checked)
            {
                ActivarDarkMode();
            }
            else
            {
                ActivarLightMode();
            }
        }

        private void ActivarDarkMode()
        {
            this.BackColor = Color.DarkGray;
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
