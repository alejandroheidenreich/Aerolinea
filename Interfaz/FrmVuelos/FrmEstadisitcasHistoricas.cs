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
            TemaActual(this.tema);
            BindingSource bs = new BindingSource();
            if (Sistema.destinosFacturados.Count > 0)
            {
                bs.DataSource = Sistema.destinosFacturados.Comparer;
                this.dtg_DestinosFacturados.DataSource = bs;
                
            }
            this.dtg_PasajerosFrecuentes.DataSource = BaseDeDatos.vuelosHistorial;
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
            this.BackColor = Color.WhiteSmoke;
            //this.pic_Lupa.BackColor = Color.WhiteSmoke;
            //this.btn_AgregarVuelo.BackColor = Color.LightGray;
            //this.btn_EliminarVuelo.BackColor = Color.LightGray;
            //this.btn_ExaminarVuelo.BackColor = Color.LightGray;
            //this.btn_VentaVuelo.BackColor = Color.LightGray;
            //this.dtg_Vuelos.DefaultCellStyle.BackColor = Color.DarkGray;
        }

        private void ActivarDarkMode()
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
