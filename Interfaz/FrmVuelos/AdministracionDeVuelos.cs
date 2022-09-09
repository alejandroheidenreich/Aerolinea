using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class AdministracionDeVuelos : Form
    {
        public AdministracionDeVuelos(bool temaActual)
        {
            InitializeComponent();
            TemaActual(temaActual);
        }

        private void TemaActual(bool temaActual)
        {
            dataGridView1.DataSource = temaActual;
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
