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


        public FrmAeronaves()
        {
            InitializeComponent();
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
            this.dtg_Aeronaves.DataSource = Sistema.aeronaves;
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
    }
}
