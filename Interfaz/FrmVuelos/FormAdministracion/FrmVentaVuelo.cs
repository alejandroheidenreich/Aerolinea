using Entidades;
using Interfaz.FrmCliente;
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
    public partial class FrmVentaVuelo : Form
    {
        private Vuelo vuelo;
        private List<DataTicket>? tickets;
        private List<Pasaje>? nuevosPasajeros;
        private bool clase;
        private int contadorDeTickets;
        private bool tema;

        public FrmVentaVuelo(Vuelo vuelo, bool temaActual)
        {
            InitializeComponent();
            this.tema = temaActual;
            this.vuelo = vuelo;
            this.contadorDeTickets = vuelo.ListaDePasajeros.Count;
        }

        public List<Pasaje>? NuevosPasajeros
        {
            get => nuevosPasajeros;
            set => nuevosPasajeros = value;
        }
        private void FrmVentaVuelo_Load(object sender, EventArgs e)
        {
            TemaActual(this.tema);
            ListarLosClientes(BaseDeDatos.clientes);
            tickets = new List<DataTicket>();
            nuevosPasajeros = new List<Pasaje>();
            VerificarExiteData();
        }
        private void TemaActual(bool temaActual)
        {
            if (temaActual)
            {
                this.BackColor = Color.DarkGray;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }
        private void ListarLosClientes(List<Cliente> listaClientes)
        {
            lst_Clientes.Items.Clear();
            foreach (Cliente item in listaClientes)
            {
                if (true)
                {
                    lst_Clientes.Items.Add(item);
                }
            }
        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_Buscar.Text))
            {
                List<Cliente> filtrado = new List<Cliente>();
                FiltrarDatosDeClientes(filtrado);
                ListarLosClientes(filtrado);
            }
            else
            {
                ListarLosClientes(BaseDeDatos.clientes);
            }
        }
        private void FiltrarDatosDeClientes(List<Cliente> filtrado)
        {
            //TODO: sacar de aca mandar a clase sistema
            foreach (Cliente item in BaseDeDatos.clientes)
            {
                if (item.Nombre.ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.Apellido.ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.Dni.ToString().ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }

            }
        }
        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente altaCliente = new FrmAltaCliente();

            DialogResult respuesta = altaCliente.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                Sistema.AltaDeCliente(altaCliente.NuevoCliente);
            }
        }

        private void btn_AgregarCompra_Click(object sender, EventArgs e)
        {
            if (this.contadorDeTickets == 10000)
            {
                //TODO: ARREGLAR 
                //this.lbl_Error.Text = "Se ha llegado al limite de pasajeros";
                //this.lbl_Error.Visible = true;
            }
            else if (this.lst_Clientes.SelectedItem is null )
            {
                this.lbl_Error.Text = "Porfavor seleccione un cliente";
                this.lbl_Error.Visible = true;
            }
            else
            {
                Pasaje pasajeAgregado = new Pasaje((Cliente)lst_Clientes.SelectedItem, VerificarPremium());
                this.lbl_Error.Visible = false;
                if (Sistema.VerificarCarritoDecompras(this.vuelo, pasajeAgregado, this.nuevosPasajeros))
                {
                    double precioFinal;
                    this.nuevosPasajeros.Add(pasajeAgregado);

                    this.vuelo.InformarConPrecioDelPasaje(pasajeAgregado, out precioFinal);
                    tickets.Add(new DataTicket(pasajeAgregado.IdRegistro, (Cliente)this.lst_Clientes.SelectedItem, VerificarPremium(), precioFinal));
                    ActualizarFacturacionActual();
                    VerificarExiteData();
                    ActualizarDataGrid(this.dtg_CarritoDeCompra, tickets);
                }
                else
                {
                    this.lbl_Error.Text = "El pasajero alcanzo el limite de pasajes por vuelo";
                    this.lbl_Error.Visible = true;
                }
            }
        }

        public void ActualizarFacturacionActual()
        {
            this.rtb_Facturacion.Clear();
            StringBuilder sb = new StringBuilder();
            double precioFinal = 0;
            double precioDelPasaje;

            foreach (Pasaje item in this.nuevosPasajeros)
            {
                sb.AppendLine(this.vuelo.InformarConPrecioDelPasaje(item, out precioDelPasaje));
                precioFinal += precioDelPasaje;
            }
            sb.AppendLine("***********************************");
            sb.AppendLine($"Precio Final Neto (+IVA) {precioFinal * 1.21} U$D");

            rtb_Facturacion.Text = sb.ToString();
        }
        public static void ActualizarDataGrid(DataGridView dtg, List<DataTicket> lista)
        {
            dtg.DataSource = null;
            dtg.DataSource = lista;

        }
        private ClaseDePasajero VerificarPremium()
        {
            if (chk_Clase.Checked)
            {
                return ClaseDePasajero.Premium;
            }
            return ClaseDePasajero.Tursita;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Sistema.AltaDePasajero(this.nuevosPasajeros, this.vuelo);
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtg_CarritoDeCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_CarritoDeCompra.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                EliminarPasajeroDeListaParcial(ObtenerSeleccionado().Registro);
                tickets.Remove(ObtenerSeleccionado());
                ActualizarDataGrid(this.dtg_CarritoDeCompra, tickets);
                ActualizarFacturacionActual();
                VerificarExiteData();
            }
        }

        private void EliminarPasajeroDeListaParcial(string idRegistro)
        {
            Pasaje pasajeBorrar = EncontrarPasaje(idRegistro);
            if (pasajeBorrar is not null)
            {
                this.nuevosPasajeros.Remove(pasajeBorrar);
            }
        }

        private Pasaje EncontrarPasaje(string idRegistro)
        {
            foreach (Pasaje item in this.nuevosPasajeros)
            {
                if (item.IdRegistro == idRegistro)
                {
                    return item;
                }
            }
            return null;
        }
        private DataTicket ObtenerSeleccionado()
        {
            return (DataTicket)dtg_CarritoDeCompra.CurrentRow.DataBoundItem;
        }

        private void VerificarExiteData()
        {
            if (tickets.Count == 0)
            {
                dtg_CarritoDeCompra.Visible = false;
            }
            else
            {
                dtg_CarritoDeCompra.Visible = true;
            }
        }

        private void btn_Equipaje_Click(object sender, EventArgs e)
        {
            if (dtg_CarritoDeCompra.Visible && dtg_CarritoDeCompra.CurrentRow.DataBoundItem is not null)
            {
                FrmAltaEquipaje frmEquipaje = new FrmAltaEquipaje();
                DialogResult respuesta = frmEquipaje.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    Pasaje pasajeAgregarEquipaje = EncontrarPasaje(ObtenerSeleccionado().Registro);

                    pasajeAgregarEquipaje.EquipajeDeMano = frmEquipaje.EquipajeDeMano;
                    foreach (double item in frmEquipaje.EquipajesBodega)
                    {
                        pasajeAgregarEquipaje.AgregarEquipaje(item);
                    }
                }
            }
            else
            {
                this.lbl_Error.Text = "Debe seleccionar un Pasajero Registrado";
                this.lbl_Error.Visible = true;
            }
        }
    }
}
