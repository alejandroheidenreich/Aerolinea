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
    public partial class FrmAeronaves : Form
    {
        private Aeronave? aeronave;
        private bool temaActual;


        public FrmAeronaves(bool temaActual)
        {
            InitializeComponent();
            this.temaActual = temaActual;
        }
        public Aeronave Aeronave
        {
            get
            {
                return aeronave;
            }
        }

        private void FrmAeronaves_Load(object sender, EventArgs e)
        {
            TemaActual(this.temaActual);
            this.dtg_Aeronaves.DataSource = BaseDeDatos.aeronaves;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            this.aeronave = ObtenerVueloSeleccionado();
            this.DialogResult = DialogResult.OK;
        }

        private Aeronave ObtenerVueloSeleccionado()
        {
            return (Aeronave)dtg_Aeronaves.CurrentRow.DataBoundItem;
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
            this.dtg_Aeronaves.BackgroundColor = Color.DarkGray;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_Salir.BackColor = Color.LightGray;
            this.btn_Seleccionar.BackColor = Color.LightGray;
        }

        private void ActivarLightMode()
        {
            this.BackColor = Color.SkyBlue;
            this.dtg_Aeronaves.BackgroundColor = Color.LightGray;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_Salir.BackColor = Color.WhiteSmoke;
            this.btn_Seleccionar.BackColor = Color.WhiteSmoke;

        }
    }
}
