using Entidades;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmInformacionDeLosPasajeros : Form
    {

        public FrmInformacionDeLosPasajeros(bool temaActual)
        {
            InitializeComponent();
            TemaActual(temaActual);
            dtg_Pasajeros.DataSource = Sistema.pasajeros;
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
                List<Pasajero> filtrado = new List<Pasajero>();
                FiltrarDatosDePasajeros(filtrado);
                this.dtg_Pasajeros.DataSource = filtrado;
            }
            else
            {
                dtg_Pasajeros.DataSource = Sistema.pasajeros;
            }
        }

        private void FiltrarDatosDePasajeros(List<Pasajero> filtrado)
        {
            foreach (Pasajero item in Sistema.pasajeros)
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
