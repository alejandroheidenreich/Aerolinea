using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    internal class FormValidador
     {
        public static void ActualizarDataGridVuelos<T>(DataGridView dtg, List<T> lista) where T : class
        {
            dtg.DataSource = null;
            dtg.DataSource = lista;

        }
    }
}
