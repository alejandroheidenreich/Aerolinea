using Entidades;
using Interfaz.FrmCuenta;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmMenuPrincipal : Form
    {
        private int usuario;
        private Form? formActivo;

        public FrmMenuPrincipal(int usuarioActual)
        {
            InitializeComponent();
            this.usuario = usuarioActual;
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            MensajeDeBarraDeInformacion(BaseDeDatos.usuarios[this.usuario]);
            ActivarTemaOscuro();
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
            this.btn_ToggleTema.Visible = true;
            this.lbl_DarkTheme.Visible = true;
        }
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmInformacionDeLosClientes(btn_ToggleTema.Checked));
        }
        private void VuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmAdministracionDeVuelos(btn_ToggleTema.Checked));
        }
        private void EstadisitcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmEstadisitcasHistoricas(btn_ToggleTema.Checked));
        }
        private void configurarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarForm(new FrmConfiguracionCuenta(this.usuario,btn_ToggleTema.Checked));
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
                this.horaToolStripMenuItem.Text = string.Empty;
            }
        }
        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivarForm(Form form)
        {
            try
            {
                OcultarForm();
                formActivo = form;
                formActivo.MdiParent = this;
                pnl_PanelDeFondo.Visible = false;
                this.btn_ToggleTema.Visible = false;
                this.lbl_DarkTheme.Visible = false;
                formActivo.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex.Message}, Reiniciar la aplicacion");
            }
        }

        private void OcultarForm()
        {
            if (formActivo is not null)
            {
                formActivo.Close();
            }
        }

        private void MensajeDeBarraDeInformacion(Usuario usuario)
        {
            DateTime fechaDeHoy = DateTime.Now;
            lbl_InfoUsuarioFecha.Text = $"Usuario: {usuario.Nombre} {usuario.Apellido}   Fecha: {fechaDeHoy.ToString("dd/MM/yyyy")}";
        }

        private void btn_ToggleCambioDeTema_Checked(object sender, EventArgs e)
        {
            if (btn_ToggleTema.Checked)
            {
                ActivarTemaOscuro();
            }
            else
            {
                ActivarTemaClaro();
            }
        }
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.DarkGray;
            pnl_barraInfo.BackColor = Color.SteelBlue;
            mnu_menuPrincipal.BackColor = Color.SteelBlue;
        }
        private void ActivarTemaClaro()
        {
            BackColor = Color.WhiteSmoke;
            pnl_barraInfo.BackColor = Color.SkyBlue;
            mnu_menuPrincipal.BackColor = Color.SkyBlue;
        }
    }
}
