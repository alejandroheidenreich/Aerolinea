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

namespace Interfaz.FrmPasajeros
{
    public partial class FrmInformacionDelPasajero : Form
    {
        private Vuelo vuelo;
        private Cliente cliente;
        private Pasaje pasaje;
        private bool tema;
        public FrmInformacionDelPasajero(Vuelo vuelo, Cliente cliente, bool tema)
        {
            InitializeComponent();
            this.vuelo = vuelo;
            this.cliente = cliente;
            this.tema = tema;
        }

        private void FrmInformacionDelPasajero_Load(object sender, EventArgs e)
        {
            TemaActual(this.tema);
            this.lbl_EncabezadoVuelo.Text = this.vuelo.ToString();
            this.lbl_EncabezadoCliente.Text = this.cliente.ToString();
            this.pasaje = Sistema.BuscarPasajePorCliente(this.vuelo, this.cliente);
            if (pasaje is null)
            {
                MessageBox.Show("Ocurrio un error");
                this.Close();
            }
            else
            {
                this.lbl_Registro.Text = pasaje.IdRegistro;
                this.lbl_Clase.Text = pasaje.Clase.ToString();
                this.lbl_EquipajeMano.Text = "No";
                if (this.pasaje.EquipajeDeMano)
                {
                    this.lbl_EquipajeMano.Text = "Si";
                }
                foreach (double item in this.pasaje.EquipajeDeBodega)
                {
                    this.lst_EquipajesBodega.Items.Add($"Equipaje con {item.ToString("0.000")} KG.");
                }
                this.lbl_PesoAdicional.Text = $"{pasaje.PesoAdicional.ToString("0.000")} KG.";
            }
        }
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TemaActual(bool temaActual)
        {
            if (temaActual)
            {
                ActivarTemaOscuro();
            }
            else
            {
                ActivarTemaClaro();
            }
        }
        private void ActivarTemaClaro()
        {
            this.BackColor = Color.SkyBlue;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_Atras.BackColor = Color.WhiteSmoke;
            this.lst_EquipajesBodega.BackColor = Color.WhiteSmoke;
        }
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_Atras.BackColor = Color.LightGray;
            this.lst_EquipajesBodega.BackColor = Color.DarkGray;
        }

        
    }
}
