﻿using Entidades;
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
            //this.pic_Lupa.BackColor = Color.WhiteSmoke;
            //this.btn_AgregarVuelo.BackColor = Color.LightGray;
            //this.btn_EliminarVuelo.BackColor = Color.LightGray;
            //this.btn_ExaminarVuelo.BackColor = Color.LightGray;
            //this.btn_VentaVuelo.BackColor = Color.LightGray;
            //this.dtg_Vuelos.DefaultCellStyle.BackColor = Color.DarkGray;
        }

        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.DarkGray;
            //this.pic_Lupa.BackColor = Color.DarkGray;
            //this.btn_AgregarVuelo.BackColor = Color.DimGray;
            //this.btn_EliminarVuelo.BackColor = Color.DimGray;
            //this.btn_ExaminarVuelo.BackColor = Color.DimGray;
            //this.btn_VentaVuelo.BackColor = Color.DimGray;
            //this.dtg_Vuelos.DefaultCellStyle.BackColor = Color.DimGray;
        }

        
    }
}