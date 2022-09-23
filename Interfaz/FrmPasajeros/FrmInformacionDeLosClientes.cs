using Entidades;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmInformacionDeLosClientes : Form
    {
        private bool ordenAscendente;
        public FrmInformacionDeLosClientes(bool temaActual)
        {
            InitializeComponent();
            TemaActual(temaActual);
            dtg_Pasajeros.DataSource = BaseDeDatos.clientes;
            this.ordenAscendente = false;
            //this.dtg_Pasajeros.Columns["Equipaje"].Visible = false;
            //this.dtg_Pasajeros.Columns["EquipajeDeBodega"].Visible = false;
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
            this.pic_Lupa.BackColor = Color.WhiteSmoke;
        }

        private void ActivarDarkMode()
        {
            this.BackColor = Color.DarkGray;
            this.pic_Lupa.BackColor = Color.DarkGray;
        }

        private void txt_Buscar_TextChanged_1(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_Buscar.Text))
            {
                List<Cliente> filtrado = new List<Cliente>();
                FiltrarDatosDeClientes(filtrado);
                this.dtg_Pasajeros.DataSource = filtrado;
            }
            else
            {
                dtg_Pasajeros.DataSource = BaseDeDatos.pasajeros;
            }
        }

        private void FiltrarDatosDeClientes(List<Cliente> filtrado)
        {
            foreach (Cliente item in BaseDeDatos.clientes)
            {
                if (item.Nombre.ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.Apellido.ToString().ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }else if (item.Dni.ToString().ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
            }
        }
    }
}
