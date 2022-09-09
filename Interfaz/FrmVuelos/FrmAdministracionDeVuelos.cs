using Entidades;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmAdministracionDeVuelos : Form
    {
        public FrmAdministracionDeVuelos(bool temaActual)
        {
            InitializeComponent();
            TemaActual(temaActual);
            dtg_Vuelos.DataSource = Data.vuelos;
            this.dtg_Vuelos.Columns["Aeronave"].Visible = false;
        }

        private void TemaActual(bool temaActual)
        {
            dtg_Vuelos.DataSource = temaActual;
            if (temaActual)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
