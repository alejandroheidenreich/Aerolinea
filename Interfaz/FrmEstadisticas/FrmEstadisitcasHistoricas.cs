using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmEstadisitcasHistoricas : Form
    {
        private bool tema;

        public FrmEstadisitcasHistoricas(bool tema)
        {
            InitializeComponent();
            this.tema = tema;
        }

        private void FrmEstadisitcasHistoricas_Load(object sender, EventArgs e)
        {
            Sistema.ActualizarListaDeVuelos();
            TemaActual(this.tema);
            BindingSource bs = new BindingSource();
            BindingSource bs2 = new BindingSource();
            BindingSource bs3 = new BindingSource();
            InformarHistorialDeVuelos();
            InformarDestinosPorFacturacion(bs);
            InformarClientesPorCantidadDeVuelos(bs2);
            InformarAeronavesCantidadDeHorasVoladas(bs3);
            this.lbl_DestinoFavorito.Text = $"Destino Favorito: {Sistema.BuscarDestinoFavorito()}";
            this.lbl_GananciasTotales.Text = $"Totales: {Sistema.InformarGananciaTotalDeLosVuelos()}";
            this.lbl_Cabotaje.Text = $"Cabotajes: {Sistema.InformarGananciaCabotajeDeLosVuelos()}";
            this.lbl_Internacional.Text = $"Internacional: {Sistema.InformarGananciaInternacionalDeLosVuelos()}";
            this.lbl_PesoAdicional.Text = $"Peso Adicional: {Sistema.InformarGananciaPesoAdicionalDeLosVuelos()}";
            this.lbl_Premium.Text = $"Premium: {Sistema.InformarGananciaPremiumAdicionalDeLosVuelos()}";
        }

        private void InformarHistorialDeVuelos()
        {
            if (BaseDeDatos.vuelosHistorial.Count > 0)
            {
                dtg_HistorialDeVuelos.Visible = true;
                dtg_HistorialDeVuelos.DataSource = BaseDeDatos.vuelosHistorial;
                dtg_HistorialDeVuelos.Columns["Aeronave"].Visible = false;
                dtg_HistorialDeVuelos.Columns["HoraDelVuelo"].Visible = false;
                dtg_HistorialDeVuelos.Columns["MinutosDelVuelo"].Visible = false;
                dtg_HistorialDeVuelos.Columns["Wifii"].Visible = false;
                dtg_HistorialDeVuelos.Columns["Comida"].Visible = false;
                dtg_HistorialDeVuelos.Columns["MenuVegano"].Visible = false;
                dtg_HistorialDeVuelos.Columns["MenuPremium"].Visible = false;
                dtg_HistorialDeVuelos.Columns["SinAlcohol"].Visible = false;
                dtg_HistorialDeVuelos.Columns["Alcoholicas"].Visible = false;
            }
            else
            {
                dtg_HistorialDeVuelos.Visible = false;
            }
        }

        private void InformarDestinosPorFacturacion(BindingSource bs)
        {
            if (Sistema.CargarDiccionarioHistorialDeVuelosPorFacturacion().Count > 0)
            {
                bs.DataSource = Sistema.CargarDiccionarioHistorialDeVuelosPorFacturacion();
                this.dtg_DestinosFacturados.DataSource = bs;
                this.dtg_DestinosFacturados.Visible = true;
            }
            else
            {
                this.dtg_DestinosFacturados.Visible = false;
                this.lbl_EncabezaDestinosFacturados.Text = "No hay vuelos en el historial";
            }
        }

        private void InformarClientesPorCantidadDeVuelos(BindingSource bs2)
        {
            if (Sistema.CargarDiccionarioClientesPorCantidadDeVuelos().Count > 0)
            {
                bs2.DataSource = Sistema.CargarDiccionarioClientesPorCantidadDeVuelos();
                this.dtg_PasajerosFrecuentes.DataSource = bs2;
                this.dtg_PasajerosFrecuentes.Visible = true;
            }
            else
            {
                this.dtg_PasajerosFrecuentes.Visible = false;
                this.lbl_EncabezaPasajerosFecuentes.Text = "No hay pasajeros en el historial";
            }
        }
        private void InformarAeronavesCantidadDeHorasVoladas(BindingSource bs3)
        {
            if (Sistema.CargarDiccionarioDeAeronavesPorCantidadDeHorasVoladas().Count > 0)
            {
                bs3.DataSource = Sistema.CargarDiccionarioDeAeronavesPorCantidadDeHorasVoladas();
                this.dtg_Aeronaves.DataSource = bs3;
                this.dtg_Aeronaves.Visible = true;
            }
            else
            {
                this.dtg_Aeronaves.Visible = false;
                this.lbl_EncabezaAeronaves.Text = "No hay aeronaves";
            }
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
        }

        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.DarkGray;
        }
    }
}
