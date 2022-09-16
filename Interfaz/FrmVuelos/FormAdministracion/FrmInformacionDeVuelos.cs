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
        public FrmInformacionDeVuelos(Vuelo vuelo)
        {
            InitializeComponent();
            this.vuelo = vuelo;
        }

        private void FrmInformacionDeVuelos_Load(object sender, EventArgs e)
        {
            this.lbl_Origen.Text = $"Origen: {vuelo.Origen}";
            this.lbl_Destino.Text = $"Destino: {vuelo.Destino}";
            this.lbl_TipoDeVuelo.Text = vuelo.Tipo.ToString();
            this.lbl_Disponibilidad.Text = vuelo.Disponibilidad;
            this.lbl_Duracion.Text = vuelo.Duracion;
            this.dtg_ListaDePasajeros.DataSource = vuelo.ListaDePasajeros;
            this.lbl_Matricula.Text = $"Matricula: {vuelo.Aeronave.Matricula}";
            this.lbl_CantidadBanios.Text = $"Baños: {vuelo.Aeronave.CantidadDeBanios}";
            this.lbl_CapacidadBodega.Text = $"Bodega: {vuelo.Aeronave.CapacidadDeBodega} KG.";
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
