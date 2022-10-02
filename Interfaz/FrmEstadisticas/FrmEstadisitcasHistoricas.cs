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

            InformarDestinosPorFacturacion(bs);
            InformarClientesPorCantidadDeVuelos(bs2);
            InformarAeronavesCantidadDeHorasVoladas(bs3);
            this.lbl_DestinoFavorito.Text = $"Destino Favorito: {Sistema.BuscarDestinoFavorito()}";
            this.lbl_GananciasTotales.Text = $"Ganancias Totales: {Sistema.InformarGananciaTotalDeLosVuelos()}";
            this.lbl_Cabotaje.Text = $"Ganancias Cabotajes: {Sistema.InformarGananciaCabotajeDeLosVuelos()}";
            this.lbl_Internacional.Text = $"Ganancias Internacional: {Sistema.InformarGananciaInternacionalDeLosVuelos()}";
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
