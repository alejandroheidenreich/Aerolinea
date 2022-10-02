using Entidades;
using Interfaz.FrmVuelos.FormAdministracion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmAdministracionDeVuelos : Form
    {
        private bool temaActual;
        private Vuelo vueloNuevo;

        public FrmAdministracionDeVuelos(bool temaActual)
        {
            InitializeComponent();
            this.temaActual = temaActual;
        }
        private void FrmAdministracionDeVuelos_Load(object sender, EventArgs e)
        {
            TemaActual(temaActual);
            ActualizarDataGrid();
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
            this.BackColor = Color.WhiteSmoke;
            this.pic_Lupa.BackColor = Color.WhiteSmoke;
            this.btn_AgregarVuelo.BackColor = Color.LightGray;
            this.btn_EliminarVuelo.BackColor = Color.LightGray;
            this.btn_ExaminarVuelo.BackColor = Color.LightGray;
            this.btn_VentaVuelo.BackColor = Color.LightGray;
            this.dtg_Vuelos.DefaultCellStyle.BackColor = Color.DarkGray;
        }
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.DarkGray;
            this.pic_Lupa.BackColor = Color.DarkGray;
            this.btn_AgregarVuelo.BackColor = Color.DimGray;
            this.btn_EliminarVuelo.BackColor = Color.DimGray;
            this.btn_ExaminarVuelo.BackColor = Color.DimGray;
            this.btn_VentaVuelo.BackColor = Color.DimGray;
            this.dtg_Vuelos.DefaultCellStyle.BackColor = Color.DimGray;
        }
        private void txt_Buscar_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_Buscar.Text))
            {
                List<Vuelo> filtrado = new List<Vuelo>();
                FiltrarDatosDeVuelo(filtrado);
                this.dtg_Vuelos.DataSource = filtrado;
            }
            else
            {
                if (BaseDeDatos.vuelosActivos.Count > 0)
                {
                    dtg_Vuelos.DataSource = BaseDeDatos.vuelosActivos;
                }
            }
        }
        private void FiltrarDatosDeVuelo(List<Vuelo> filtrado)
        {
            foreach (Vuelo item in BaseDeDatos.vuelosActivos)
            {
                if (item.Origen.ToString().ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.Destino.ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.Tipo.ToString().ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }

            }
        }
        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            FrmAltaVuelo altaVuelo = new FrmAltaVuelo(this.temaActual);
            DialogResult respuesta = altaVuelo.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                this.vueloNuevo = altaVuelo.VueloNuevo;
                Sistema.AltaDeVuelo(this.vueloNuevo);
                ActualizarDataGrid();
            }
        }
        private void btn_EliminarVuelo_Click(object sender, EventArgs e)
        {
            if (dtg_Vuelos.RowCount == 0)
            {
                this.lbl_Error.Text = "No hay vuelos para eliminar";
                this.lbl_Error.Visible = true;
            }
            else
            {
                DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere eliminar?{Environment.NewLine} Esta accion es inrreversible", "Eliminar Vuelo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        Sistema.BajaDeVuelo(ObtenerVueloSeleccionado());
                        ActualizarDataGrid();

                    }
                    catch (Exception ex)
                    {

                        this.lbl_Error.Text = ex.Message;
                        this.lbl_Error.Visible = true;
                    }
                }
            }
        }
        public void ActualizarDataGrid()
        {
            if (BaseDeDatos.vuelosActivos.Count > 0)
            {
                Sistema.ActualizarListaDeVuelos();
                dtg_Vuelos.DataSource = null;
                dtg_Vuelos.DataSource = BaseDeDatos.vuelosActivos;
                dtg_Vuelos.Columns["Aeronave"].Visible = false;
                dtg_Vuelos.Columns["Premium"].Visible = false;
                dtg_Vuelos.Columns["Tursita"].Visible = false;
                dtg_Vuelos.Columns["HoraDelVuelo"].Visible = false;
                dtg_Vuelos.Columns["MinutosDelVuelo"].Visible = false;
                dtg_Vuelos.Visible = true;
            }
            else
            {
                dtg_Vuelos.Visible = false;
            }
        }
        private Vuelo ObtenerVueloSeleccionado()
        {
            return (Vuelo)dtg_Vuelos.CurrentRow.DataBoundItem;
        }
        private void btn_ExaminarVuelo_Click(object sender, EventArgs e)
        {
            if (dtg_Vuelos.RowCount == 0)
            {
                this.lbl_Error.Text = "No hay vuelos para examinar";
                this.lbl_Error.Visible = true;
            }
            else
            {
                FrmInformacionDeVuelos infoVuelo = new FrmInformacionDeVuelos(ObtenerVueloSeleccionado(),this.temaActual);
                infoVuelo.ShowDialog();
            }
        }
        private void btn_VentaVuelo_Click(object sender, EventArgs e)
        {
            if (dtg_Vuelos.RowCount == 0)
            {
                this.lbl_Error.Text = "No hay vuelos para vender";
                this.lbl_Error.Visible = true;
            }
            else
            {
                if (ObtenerVueloSeleccionado().Disponibilidad == "COMPLETO" || 
                    ObtenerVueloSeleccionado().Disponibilidad == "EN VUELO" ||
                    ObtenerVueloSeleccionado().Disponibilidad == "FINALIZADO")
                {
                    this.lbl_Error.Text = $"El vuelo que se desea vender ya esta {ObtenerVueloSeleccionado().Disponibilidad}";
                    this.lbl_Error.Visible = true;
                }
                else
                {
                    this.lbl_Error.Visible = false;
                    FrmVentaVuelo ventaVuelo = new FrmVentaVuelo(ObtenerVueloSeleccionado(), this.temaActual);
                    DialogResult respuesta = ventaVuelo.ShowDialog();
                    if (respuesta == DialogResult.OK)
                    {
                        ActualizarDataGrid();
                    }
                }
            }
        }
        private void btn_VentaVuelo_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Vender Pasaje",this.btn_VentaVuelo);
        }
        private void btn_AgregarVuelo_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Agregar Vuelo", this.btn_AgregarVuelo);
        }
        private void btn_ExaminarVuelo_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Examinar Vuelo", this.btn_ExaminarVuelo);
        }
        private void btn_EliminarVuelo_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Eliminar Vuelo", this.btn_EliminarVuelo);
        }
        private void txt_Buscar_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Filtrar la Lista de Vuelos por Origen, Desitno o Tipo", this.txt_Buscar);
        }
    }
}
