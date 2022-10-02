using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.FrmCliente
{
    public partial class FrmAltaCliente : Form
    {
        private Cliente? nuevoCliente;
        private bool tema;

        public Cliente NuevoCliente
        {
            get => nuevoCliente!;
        }
        public FrmAltaCliente(bool tema)
        {
            InitializeComponent();
            this.tema = tema;
        }
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
            dtp_Nacimiento.MaxDate = DateTime.Now;
            dtp_Nacimiento.MinDate = new DateTime(1900, 1, 1);
            TemaActual(tema);
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
            this.BackColor = Color.SkyBlue;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_Agregar.BackColor = Color.LightGray;
            this.btn_Salir.BackColor = Color.LightGray;
            this.lbl_EncabezadoNacimiento.BackColor = Color.WhiteSmoke;
        }
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_Agregar.BackColor = Color.DimGray;
            this.btn_Salir.BackColor = Color.DimGray;
            this.lbl_EncabezadoNacimiento.BackColor = Color.DarkGray;
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
                DateTime fechaActual = DateTime.Now;
                this.nuevoCliente = new Cliente(this.txt_Nombre.Text, this.txt_Apellido.Text, this.dtp_Nacimiento.Value.Date, dni, this.txt_Email.Text, fechaActual);
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
