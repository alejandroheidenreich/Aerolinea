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

namespace Interfaz.FrmCuenta
{
    public partial class FrmConfiguracionCuenta : Form
    {
        private bool temaActual;
        private Usuario usuarioActual;
        public FrmConfiguracionCuenta(Usuario usuarioActual, bool temaActual)
        {
            InitializeComponent();
            this.temaActual = temaActual;
            this.usuarioActual = usuarioActual;
        }
        private void FrmConfiguracionCuenta_Load(object sender, EventArgs e)
        {
            TemaActual(this.temaActual);
            lbl_bienvenida.Text = $"¡Bienvenido {this.usuarioActual.Nombre}!";
            this.lbl_Nombre.Text = this.usuarioActual.Nombre;
            this.lbl_Apellido.Text = this.usuarioActual.Apellido;
            this.lbl_Nacimiento.Text = this.usuarioActual.FechaDeNacimiento.ToString("dd/MM/yyyy");
            this.lbl_Email.Text = this.usuarioActual.Email;
        }

        private void TemaActual(bool temaActual)
        {
            if (temaActual)
            {
                ActivarDarkMode();
            }
            else
            {
                ActivarLightMode();
            }
        }
        private void ActivarLightMode()
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void ActivarDarkMode()
        {
            this.BackColor = Color.DarkGray;
        }

        private void lbl_CambiarEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmVerificarContrasenia formContrasenia = new FrmVerificarContrasenia(this.usuarioActual,this.temaActual);
            formContrasenia.ShowDialog();
        }
    }
}
