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

namespace Interfaz.FrmVuelos.FormAdministracion
{
    public partial class FrmAltaVuelo : Form
    {
        private bool fechaCambio;
        public FrmAltaVuelo()
        {
            //TODO: DESARROLLAR VER DESTINO ENUM PARA UN SOLO ENUM
            InitializeComponent();
            this.fechaCambio = false;
        }

        private void FrmAltaVuelo_Load(object sender, EventArgs e)
        {
            lbl_MensajeError.Visible = false;
            foreach (string item in Sistema.localidades)
            {
                cmb_Origen.Items.Add(item);
                cmb_Destino.Items.Add(item);
            }
            foreach (Aeronave item in Sistema.aeronaves)
            {
                cmb_Aeronave.Items.Add(item.Matricula);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MasInfoAeronave_Click(object sender, EventArgs e)
        {
            FrmAeronaves dataAeronaves = new FrmAeronaves();

            DialogResult respuesta = dataAeronaves.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                cmb_Aeronave.Text = dataAeronaves.Aeronave.Matricula;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (VerificarIngresos())
            {
                Aeronave aeronave = Sistema.BuscarAeronavePorMatricula(cmb_Aeronave.Text);
                if (aeronave is not null)
                {
                    Sistema.AltaDeVuelo(new Vuelo(aeronave, cmb_Origen.Text, cmb_Destino.Text,dtp_Partida.Value));//TODO: ARREGLAR
                    this.Close();
                }
            }
        }

        private bool VerificarIngresos()
        {
            lbl_MensajeError.Visible = false;
            if (String.IsNullOrEmpty(cmb_Origen.Text) || String.IsNullOrEmpty(cmb_Destino.Text) || String.IsNullOrEmpty(cmb_Aeronave.Text) || ! this.fechaCambio)
            {
                lbl_MensajeError.Text = "       Datos Incompletos";
                lbl_MensajeError.Visible = true;
                return false;
            }
            else if (cmb_Origen.Text == cmb_Destino.Text)
            {
                lbl_MensajeError.Text = "       Destino y Origen no pueden ser iguales";
                lbl_MensajeError.Visible = true;
                return false;
            }
            return true;
        }

        private void dtp_Partida_ValueChanged(object sender, EventArgs e)
        {
            this.fechaCambio = true;
        }
    }
}
