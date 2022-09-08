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
    public partial class ListaDeVuelos : Form
    {
        private Usuario usuarioActual;
        private bool darkTheme;
        public ListaDeVuelos(Usuario usuarioActual, bool darkTheme)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.darkTheme = darkTheme;
            TemaActual();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(usuarioActual);
            this.Hide();
            menuPrincipal.ShowDialog();
        }

        private void TemaActual()
        {
            if (this.darkTheme)
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
