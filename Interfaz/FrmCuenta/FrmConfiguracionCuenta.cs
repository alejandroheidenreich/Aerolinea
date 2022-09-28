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
            this.lbl_Nacimiento.Text = this.usuarioActual.Nacimiento.ToString("dd/MM/yyyy");
            this.lbl_Email.Text = this.usuarioActual.Email;
        }

        private void TemaActual(bool temaActual)
        {
            if (temaActual)
            {
                ActivarTemaOscuro();
            }
            else
            {
                ActivarTemaClaro();
            }
        }
        private void ActivarTemaClaro()
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.DarkGray;
        }

        private void lbl_CambiarEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FrmVerificarContrasenia formContrasenia = new FrmVerificarContrasenia(this.usuarioActual,this.temaActual);
            //formContrasenia.ShowDialog();

            try
            {
                Usuario usuario = new Usuario("Jose", "Argento", new DateTime(1955, 10, 19), 11111111, "pepe@gmal.com", "pepe", "Pep3");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Se produjo el siguiente error: {ex.Message}");
            }
        }


    }
}
