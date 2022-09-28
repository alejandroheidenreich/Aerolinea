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
        private int usuario;
        public FrmConfiguracionCuenta(int usuario, bool temaActual)
        {
            InitializeComponent();
            this.temaActual = temaActual;
            this.usuario = usuario;
        }
        private void FrmConfiguracionCuenta_Load(object sender, EventArgs e)
        {
            TemaActual(this.temaActual);
            ActualizarDatosDelUsuario();
        }

        private void ActualizarDatosDelUsuario()
        {
            this.usuarioActual = BaseDeDatos.usuarios[this.usuario];
            this.lbl_bienvenida.Text = $"¡Bienvenido {this.usuarioActual.Nombre}!";
            this.lbl_Usuario.Text = this.usuarioActual.NombreDeUsuario;
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
            this.pnl_EditarUsuario.BackColor = Color.SkyBlue;
            this.btn_Guardar.BackColor = Color.DarkGray;
            this.btn_Cancelar.BackColor = Color.LightGray;
        }

        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.DarkGray;
            this.pnl_EditarUsuario.BackColor = Color.SteelBlue;
            this.btn_Guardar.BackColor = Color.DimGray;
            this.btn_Cancelar.BackColor = Color.DarkGray;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            pnl_EditarUsuario.Visible = true;
            this.txt_UsuarioEditar.Text = this.usuarioActual.NombreDeUsuario;
            this.txt_NombreEditar.Text = this.usuarioActual.Nombre;
            this.txt_ApellidoEditar.Text = this.usuarioActual.Apellido;
            this.txt_EmailEditar.Text = this.usuarioActual.Email;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!this.usuarioActual.VerificarContrasenia(txt_Contrasenia.Text))
            {

                lbl_Error.Text = "La contraseña es incorrecta";
                lbl_Error.Visible = true;
            }
            else if (string.IsNullOrEmpty(txt_UsuarioEditar.Text) ||
                    string.IsNullOrEmpty(txt_NombreEditar.Text) ||
                    string.IsNullOrEmpty(txt_ApellidoEditar.Text) ||
                    string.IsNullOrEmpty(txt_EmailEditar.Text))
            {
                lbl_Error.Text = "Todos los campos tienen que estar completados";
                lbl_Error.Visible = true;
            }
            else
            {
                //TODO: EDITAR PERFIL
                Usuario usuarioEditado = new Usuario(this.txt_NombreEditar.Text, this.txt_ApellidoEditar.Text, this.usuarioActual.Nacimiento, this.usuarioActual.GetHashCode(), this.txt_EmailEditar.Text, this.txt_UsuarioEditar.Text, this.txt_Contrasenia.Text);

                if (Sistema.EditarUsuario(usuarioEditado))
                {
                    //usuarioActual = usuarioEditado;
                    //MessageBox.Show("Perfil ediatdo");
                    pnl_EditarUsuario.Visible = false;
                    ActualizarDatosDelUsuario();
                }
                else
                {
                    lbl_Error.Text = "Ocurrio un error, no se pudo editar";
                    lbl_Error.Visible = true;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            pnl_EditarUsuario.Visible = false;
        }
    }
}
