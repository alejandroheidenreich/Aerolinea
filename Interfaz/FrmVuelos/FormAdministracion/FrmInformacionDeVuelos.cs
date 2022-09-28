using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.FrmVuelos.FormAdministracion
{
    public partial class FrmInformacionDeVuelos : Form
    {
        private Vuelo vuelo;
        private bool temaActual;
        List<Cliente> listaClientes;
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;
        public FrmInformacionDeVuelos(Vuelo vuelo, bool temaActual)
        {
            InitializeComponent();
            this.vuelo = vuelo;
            this.temaActual = temaActual;
        }

        private void FrmInformacionDeVuelos_Load(object sender, EventArgs e)
        {
            TemaActual(temaActual);
            this.lbl_Origen.Text = $"Origen: {vuelo.Origen}";
            this.lbl_Destino.Text = $"Destino: {vuelo.Destino}";
            this.lbl_TipoDeVuelo.Text = vuelo.Tipo.ToString();
            this.lbl_Duracion.Text = $"Duracion: {vuelo.Duracion}";
            this.lbl_Partida.Text = $"Partida: {vuelo.Partida.ToString("HH:mm - dd/MM/yyyy")}";
            this.lbl_Aeronave.Text = this.vuelo.Aeronave.ToString();
            this.lbl_DispoBodega.Text = $"Bodega Actual: {this.vuelo.EspacioDisponibleBodega()}/{this.vuelo.Aeronave.Bodega} KG.";
            this.lbl_Premium.Text = $"Premium: {vuelo.Premium}/{vuelo.Aeronave.Premium}";
            this.lbl_Turista.Text = $"Tursita: {vuelo.Tursita}/{vuelo.Aeronave.Tursita}";

            listaClientes = new List<Cliente>();
            foreach (Pasaje item in this.vuelo.ListaDePasajeros)
            {
                listaClientes.Add(item.Cliente);
            }
            this.dtg_ListaDePasajeros.DataSource = this.listaClientes;
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
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_Aeronave.BackColor = Color.LightGray;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_Atras.BackColor = Color.LightGray;
            this.lbl_Origen.BackColor = Color.DarkGray;
            this.lbl_Destino.BackColor = Color.DarkGray;
            this.lbl_TipoDeVuelo.BackColor = Color.DarkGray;
            this.lbl_Duracion.BackColor = Color.DarkGray;
            this.lbl_Partida.BackColor = Color.DarkGray;
            this.lbl_EncabezadoAeronave.BackColor = Color.LightGray;
            this.lbl_Aeronave.BackColor = Color.LightGray;
            this.lbl_DispoBodega.BackColor = Color.LightGray;
            this.lbl_Premium.BackColor = Color.LightGray;
            this.lbl_Turista.BackColor = Color.LightGray;
        }

        private void ActivarTemaClaro()
        {
            this.BackColor = Color.SkyBlue;
            this.pnl_Aeronave.BackColor = Color.LightGray;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_Atras.BackColor = Color.WhiteSmoke;
            this.lbl_Origen.BackColor = Color.WhiteSmoke;
            this.lbl_Destino.BackColor = Color.WhiteSmoke;
            this.lbl_TipoDeVuelo.BackColor = Color.WhiteSmoke;
            this.lbl_Duracion.BackColor = Color.WhiteSmoke;
            this.lbl_Partida.BackColor = Color.WhiteSmoke;
            this.lbl_EncabezadoAeronave.BackColor = Color.LightGray;
            this.lbl_Aeronave.BackColor = Color.LightGray;
            this.lbl_DispoBodega.BackColor = Color.LightGray;
            this.lbl_Premium.BackColor = Color.LightGray;
            this.lbl_Turista.BackColor = Color.LightGray;
        }

        private void FrmInformacionDeVuelos_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }

        private void FrmInformacionDeVuelos_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }

        private void FrmInformacionDeVuelos_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }

        private void pnl_Fondo_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }

        private void pnl_Fondo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }

        private void pnl_Fondo_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }
    }
}
