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
    public partial class FrmAltaCliente : Form
    {
        private Cliente? nuevoCliente;

        public Cliente? NuevoCliente
        {
            get => nuevoCliente;
        }

        public FrmAltaCliente()
        {
            InitializeComponent();
        }
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
            dtp_Nacimiento.MaxDate = DateTime.Now;
            dtp_Nacimiento.MinDate = new DateTime(1900, 1, 1);

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni;
                int.TryParse(this.txt_Dni.Text, out dni);

                this.nuevoCliente = new Cliente(this.txt_Nombre.Text, this.txt_Apellido.Text, this.dtp_Nacimiento.Value, dni, this.txt_Email.Text);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }

    }
}
