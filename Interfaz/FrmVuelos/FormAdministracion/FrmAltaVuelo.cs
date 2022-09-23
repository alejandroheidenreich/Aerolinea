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
        private bool temaActual;
        public FrmAltaVuelo(bool temaActual)
        {
            //TODO: DESARROLLAR VER DESTINO ENUM PARA UN SOLO ENUM
            InitializeComponent();
            this.fechaCambio = false;
            this.temaActual = temaActual;
    }

        private void FrmAltaVuelo_Load(object sender, EventArgs e)
        {
            TemaActual(this.temaActual);
            lbl_MensajeError.Visible = false;
            
            foreach (string item in BaseDeDatos.localidades)
            {
                cmb_Origen.Items.Add(item);
                cmb_Destino.Items.Add(item);
            }
            foreach (Aeronave item in BaseDeDatos.aeronaves)
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
            FrmAeronaves dataAeronaves = new FrmAeronaves(this.temaActual);

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
                    try
                    {
                        Sistema.AltaDeVuelo(new Vuelo(aeronave, cmb_Origen.Text, cmb_Destino.Text,dtp_Partida.Value));
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        this.lbl_MensajeError.Text = $"       {ex.Message}";
                        this.lbl_MensajeError.Visible = true;
                    }
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
        private void ActivarDarkMode()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_FondoPrincipal.BackColor = Color.DarkGray;
            this.lbl_Aeronave.BackColor = Color.DarkGray;
            this.lbl_Origen.BackColor = Color.DarkGray;
            this.lbl_Destino.BackColor = Color.DarkGray;
            this.lbl_Partida.BackColor = Color.DarkGray;
            this.btn_Salir.BackColor = Color.LightGray;
            this.btn_MasInfoAeronave.BackColor = Color.LightGray;
            this.btn_Agregar.BackColor = Color.LightGray;
            this.lbl_MensajeError.BackColor = Color.DarkGray;
        }

        private void ActivarLightMode()
        {
            this.BackColor = Color.SkyBlue;
            this.pnl_FondoPrincipal.BackColor = Color.WhiteSmoke;
            this.lbl_Aeronave.BackColor = Color.WhiteSmoke;
            this.lbl_Origen.BackColor = Color.WhiteSmoke;
            this.lbl_Destino.BackColor = Color.WhiteSmoke;
            this.lbl_Partida.BackColor = Color.WhiteSmoke;
            this.btn_Salir.BackColor = Color.WhiteSmoke;
            this.btn_MasInfoAeronave.BackColor = Color.WhiteSmoke;
            this.btn_Agregar.BackColor = Color.WhiteSmoke;
            this.lbl_MensajeError.BackColor = Color.WhiteSmoke;
        }
    }
}
