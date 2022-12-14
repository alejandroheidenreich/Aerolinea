using Entidades;
using Interfaz.FrmPasajeros;
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
        List<Cliente>? listaClientes;
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
            listaClientes = new List<Cliente>();
            TemaActual(temaActual);

            this.lbl_Origen.Text = $"Origen: {vuelo.Origen}";
            this.lbl_Destino.Text = $"Destino: {vuelo.Destino}";
            this.lbl_TipoDeVuelo.Text = vuelo.Tipo.ToString();
            this.lbl_Duracion.Text = $"Duracion: {vuelo.Duracion}";
            this.lbl_Partida.Text = $"Partida: {vuelo.Partida.ToString("HH:mm - dd/MM/yyyy")}";
            this.lbl_Aeronave.Text = this.vuelo.Aeronave.ToString();
            this.lbl_DispoBodega.Text = $"Bodega Actual: {(this.vuelo.Aeronave.Bodega - this.vuelo.CalcularEspacioDisponibleBodega())}/{this.vuelo.Aeronave.Bodega} KG.";
            this.lbl_Premium.Text = $"Premium: {vuelo.Premium}/{vuelo.Aeronave.Premium}";
            this.lbl_Turista.Text = $"Tursita: {vuelo.Tursita}/{vuelo.Aeronave.Tursita}";

            CargarListaDeClientesDelVuelo();
            this.dtg_ListaDePasajeros.DataSource = this.listaClientes;
            this.dtg_ListaDePasajeros.Columns["Email"].Visible = false;
            this.dtg_ListaDePasajeros.Columns["Antiguedad"].Visible = false;
        }

        private void CargarListaDeClientesDelVuelo()
        {
            foreach (Pasaje item in this.vuelo.ListaDePasajeros)
            {
                listaClientes!.Add(item.Cliente);
            }
        }

        private void btn_ExaminarPasaje_Click(object sender, EventArgs e)
        {
            FrmInformacionDelPasajero formPasajero = new FrmInformacionDelPasajero(this.vuelo, ObtenerClienteSeleccionado(), this.temaActual);
            formPasajero.ShowDialog();
        }
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Cliente ObtenerClienteSeleccionado()
        {
            return (Cliente)this.dtg_ListaDePasajeros.CurrentRow.DataBoundItem;
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
            this.pnl_Aeronave.BackColor = Color.LightGray;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_Atras.BackColor = Color.WhiteSmoke;
            this.btn_ExaminarPasaje.BackColor = Color.LightGray;
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
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_Aeronave.BackColor = Color.LightGray;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_Atras.BackColor = Color.LightGray;
            this.btn_ExaminarPasaje.BackColor = Color.DimGray;
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

        private void btn_ExaminarPasaje_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Informacion del Pasaje", this.btn_ExaminarPasaje);
        }
    }
}
