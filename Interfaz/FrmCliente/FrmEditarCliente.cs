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

namespace Interfaz.FrmCliente
{
    public partial class FrmEditarCliente : Form
    {
        private Cliente editarCliente;
        private bool tema;
        public FrmEditarCliente(bool tema, Cliente editarCliente)
        {
            InitializeComponent();
            this.editarCliente = editarCliente;
            this.tema = tema;
        }
        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            txt_Nombre.Text = editarCliente.Nombre;
            txt_Apellido.Text = editarCliente.Apellido;
            txt_Dni.Text = editarCliente.Dni.ToString();
            dtp_Nacimiento.Value = editarCliente.Nacimiento;
            txt_Email.Text = editarCliente.Email;
            this.TemaActual(tema);
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
            this.BackColor = Color.SkyBlue;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_EditarCliente.BackColor = Color.LightGray;
            this.btn_Salir.BackColor = Color.LightGray;
            //this.lbl_EncabezadoNacimiento.BackColor = Color.WhiteSmoke;
        }

        private void ActivarDarkMode()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_EditarCliente.BackColor = Color.DimGray;
            this.btn_Salir.BackColor = Color.DimGray;
            //this.lbl_EncabezadoNacimiento.BackColor = Color.DarkGray;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EditarCliente_Click(object sender, EventArgs e)
        {
            editarCliente.Nombre = txt_Nombre.Text;
            editarCliente.Apellido = txt_Apellido.Text;
            editarCliente.Email = txt_Email.Text;
            editarCliente.Nacimiento = dtp_Nacimiento.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
