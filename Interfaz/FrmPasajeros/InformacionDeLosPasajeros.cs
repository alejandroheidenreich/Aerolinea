using System.Windows.Forms;

namespace Interfaz
{
    public partial class InformacionDeLosPasajeros : Form
    {
        private bool temaActual;
        public InformacionDeLosPasajeros(bool temaActual)
        {
            InitializeComponent();
            this.temaActual = temaActual;
        }
    }
}
