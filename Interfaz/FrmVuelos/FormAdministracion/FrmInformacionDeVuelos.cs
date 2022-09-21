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

namespace Interfaz.FrmVuelos.FormAdministracion
{
    public partial class FrmInformacionDeVuelos : Form
    {
        private Vuelo vuelo;
        private bool temaActual;
        public FrmInformacionDeVuelos(Vuelo vuelo, bool temaActual)
        {
            InitializeComponent();
            this.vuelo = vuelo;
            this.temaActual = temaActual;
        }

        private void FrmInformacionDeVuelos_Load(object sender, EventArgs e)
        {
            TemaActual(temaActual);
            this.lbl_Origen.Text = $"Origen: {vuelo.Origen}";
            this.lbl_Destino.Text = $"Destino: {vuelo.Destino}";
            this.lbl_TipoDeVuelo.Text = vuelo.Tipo.ToString();
            this.lbl_Disponibilidad.Text = $"Disponibilidad: {vuelo.Disponibilidad}";
            this.lbl_Duracion.Text = $"Duracion: {vuelo.Duracion}";
            this.lbl_Partida.Text = $"Partida: {vuelo.Partida.ToString("HH:mm - dd/MM/yyyy")}";
            this.dtg_ListaDePasajeros.DataSource = vuelo.ListaDePasajeros;
            this.lbl_Matricula.Text = $"Matricula: {vuelo.Aeronave.Matricula}";
            this.lbl_CantidadBanios.Text = $"Baños: {vuelo.Aeronave.Baños}";
            this.lbl_CapacidadBodega.Text = $"Bodega: {vuelo.Aeronave.Bodega} KG.";
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.pnl_Aeronave.BackColor = Color.LightGray;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_Atras.BackColor = Color.LightGray;
            this.lbl_Origen.BackColor = Color.DarkGray;
            this.lbl_Destino.BackColor = Color.DarkGray;
            this.lbl_TipoDeVuelo.BackColor = Color.DarkGray;
            this.lbl_Duracion.BackColor = Color.DarkGray;
            this.lbl_Partida.BackColor = Color.DarkGray;
            this.lbl_EncabezadoAeronave.BackColor = Color.LightGray;
            this.lbl_Disponibilidad.BackColor = Color.LightGray;
            this.lbl_Matricula.BackColor = Color.LightGray;
            this.lbl_CantidadBanios.BackColor = Color.LightGray;
            this.lbl_CapacidadBodega.BackColor = Color.LightGray;
        }

        private void ActivarLightMode()
        {
            this.BackColor = Color.SkyBlue;
            this.pnl_Aeronave.BackColor = Color.LightGray;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_Atras.BackColor = Color.WhiteSmoke;
            this.lbl_Origen.BackColor = Color.WhiteSmoke;
            this.lbl_Destino.BackColor = Color.WhiteSmoke;
            this.lbl_TipoDeVuelo.BackColor = Color.WhiteSmoke;
            this.lbl_Duracion.BackColor = Color.WhiteSmoke;
            this.lbl_Partida.BackColor = Color.WhiteSmoke;
            this.lbl_EncabezadoAeronave.BackColor = Color.LightGray;
            this.lbl_Disponibilidad.BackColor = Color.LightGray;
            this.lbl_Matricula.BackColor = Color.LightGray;
            this.lbl_CantidadBanios.BackColor = Color.LightGray;
            this.lbl_CapacidadBodega.BackColor = Color.LightGray;
        }
    }
}
