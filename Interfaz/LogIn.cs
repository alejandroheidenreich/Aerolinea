using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Interfaz
{
    public partial class LogIn : Form
    {
        private List<Usuario> usuariosDisponibles;
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;

        public LogIn()
        {
            InitializeComponent();
            usuariosDisponibles = new List<Usuario>()
            {
            new Usuario("HeidenreichAlejandro","contraseña123"),
            new Usuario("Pepito","asd123"),
            new Usuario("Roberto12","messipasion")
            };
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
                Usuario usuarioIngresado = new Usuario(txt_usuario.Text, txt_contrasenia.Text);
                if (ValidarUsuario(usuarioIngresado))
                {
                    AccederAlMenuPrincipal(usuarioIngresado);
                }
                else
                {
                    MostrarMensajeDeError("Datos incorrectos");
                }
            }
        } 

        private void MostrarMensajeDeError(string mensaje)
        {
            lbl_mensajeDeError.Text = "     " + mensaje;
            lbl_mensajeDeError.Visible = true;
        }
        private bool ValidarUsuario(Usuario usuarioAValidar)
        {
            foreach (Usuario item in usuariosDisponibles)
            {
                if (item == usuarioAValidar)
                {
                    return true;
                }
            }
            return false;
        }

        private void AccederAlMenuPrincipal(Usuario usuarioIngresado)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(usuarioIngresado);
            this.Hide();
            menuPrincipal.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_BotonAutoCompletado_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "HeidenreichAlejandro";
            txt_contrasenia.Text = "contraseña123";
        }
        private void lbl_recuperarContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Contactese con soporte{Environment.NewLine}Se cerrara la aplicacion", "Cerrando Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            Application.Exit();
        }

        #region Mover el log in desde el fondo
        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseAccion = true;
            mousePosX = e.X;
            mousePosY = e.Y;
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
            mouseAccion = false;
        }
        #endregion

        # region Mover el log in desde la imagen
        private void pic_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseAccion = true;
            mousePosX = e.X;
            mousePosY = e.Y;
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
            mouseAccion = false;
        }
        #endregion
    }
}