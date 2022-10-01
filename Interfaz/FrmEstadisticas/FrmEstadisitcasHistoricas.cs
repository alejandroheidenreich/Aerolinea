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
            Sistema.ActualizarVuelos();
            TemaActual(this.tema);
            BindingSource bs = new BindingSource();
            BindingSource bs2 = new BindingSource();
            BindingSource bs3 = new BindingSource();

            bs.DataSource = Sistema.HistorialDeVuelosPorFacturacion();
            if (Sistema.ClientesPorCantidadDeVuelos().Count == 0)
            {
                this.dtg_PasajerosFrecuentes.Visible = false;
                this.lbl_EncabezaPasajerosFecuentes.Text = "No hay pasajeros en el historial";
            }
            bs2.DataSource = Sistema.ClientesPorCantidadDeVuelos();
            bs3.DataSource = Sistema.AeronaveCantidadDeHoras();

            this.dtg_DestinosFacturados.DataSource = bs;
            this.dtg_PasajerosFrecuentes.DataSource = bs2;
            this.dtg_Aeronaves.DataSource = bs3;
            this.lbl_DestinoFavorito.Text = $"Destino Favorito: {Sistema.DestinoFavorito()}";
            this.lbl_GananciasTotales.Text = $"Ganancias Totales: {Sistema.InformarGananciaTotalDeLosVuelos()}";
            this.lbl_Cabotaje.Text = $"Ganancias Cabotajes: {Sistema.InformarGananciaCabotajeDeLosVuelos()}";
            this.lbl_Internacional.Text = $"Ganancias Internacional: {Sistema.InformarGananciaInternacionalDeLosVuelos()}";
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
