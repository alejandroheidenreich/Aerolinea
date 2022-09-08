using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Application = System.Windows.Forms.Application;

namespace Interfaz
{
    public partial class LogIn : Form
    {
        private Usuario usuarioIngresado;
        private List<Usuario> usuariosDisponibles = new List<Usuario>() 
        { 
            new Usuario("HeidenreichAlejandro","contraseña123"),
            new Usuario("Pepito","asd123"),
            new Usuario("Roberto12","messipasion")
        };
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;

        public LogIn()
        {
            InitializeComponent();
            usuarioIngresado = new Usuario("0","0");
        }

        public Usuario Usuario
        {
            get { return usuarioIngresado; }
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
                usuarioIngresado = new Usuario(txt_usuario.Text, txt_contrasenia.Text);
                foreach (Usuario item in usuariosDisponibles)
                {
                    if (item == usuarioIngresado)
                    {
                        MenuPrincipal menuPrincipal = new MenuPrincipal(usuarioIngresado);
                        this.Hide();
                        menuPrincipal.ShowDialog();
                    }
                    else
                    {
                        MostrarMensajeDeError("Datos incorrectos");
                    }
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

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

        private void MostrarMensajeDeError(string mensaje)
        {
            lbl_mensajeDeError.Text = "     " + mensaje;
            lbl_mensajeDeError.Visible = true;
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
    }
}