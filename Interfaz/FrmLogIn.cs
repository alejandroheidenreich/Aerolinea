
using Entidades;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmLogIn : Form
    {
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;

        public FrmLogIn()
        {
            InitializeComponent();
        }


        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_usuario.Text))
            {
                MostrarMensajeDeError("Por favor, ingrese un usuario");
            }
            else if (String.IsNullOrEmpty(txt_contrasenia.Text))
            {
                MostrarMensajeDeError("Por favor, ingrese una contraseña");
            }
            else
            {
                try
                {
                    Usuario usuarioIngresado = Sistema.VerificarUsuarioContrasenia(txt_usuario.Text, txt_contrasenia.Text);
                    if (usuarioIngresado is not null)
                    {
                        AccederAlMenuPrincipal(usuarioIngresado);
                    }
                    else
                    {
                        MostrarMensajeDeError("Datos incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No es valido: {ex.Message}");
                }

            }
        }

        private void MostrarMensajeDeError(string mensaje)
        {
            lbl_mensajeDeError.Text = "     " + mensaje;
            lbl_mensajeDeError.Visible = true;
        }

        private void AccederAlMenuPrincipal(Usuario usuarioIngresado)
        {
            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(usuarioIngresado);
            this.Hide();
            menuPrincipal.ShowDialog();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_BotonAutoCompletado_Click(object sender, EventArgs e)
        {
            this.txt_usuario.Text = "HeidenreichAlejandro";
            this.txt_contrasenia.Text = "Contraseña123#";
        }
        private void lbl_recuperarContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Contactar a soporte{Environment.NewLine}Se cerrara la aplicacion", "Cerrando Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            Application.Exit();
        }
        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }
        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }
        private void LogIn_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }

        private void pic_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }
        private void pic_Logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }
        private void pic_Logo_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }

    }
}