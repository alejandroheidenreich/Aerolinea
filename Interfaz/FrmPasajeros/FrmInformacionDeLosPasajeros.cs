using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmInformacionDeLosPasajeros : Form
    {
        private bool temaActual;
        public FrmInformacionDeLosPasajeros(bool temaActual)
        {
            InitializeComponent();
            this.temaActual = temaActual;
        }
    }
}
