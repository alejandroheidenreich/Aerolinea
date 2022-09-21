using Entidades;
using Interfaz.FrmCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.FrmVuelos.FormAdministracion
{
    public partial class FrmVentaVuelo : Form
    {
        private Vuelo vuelo;
        private List<DataTicket>? tickets;
        private List<Pasajero>? nuevosPasajeros;
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

        public List<Pasajero>? NuevosPasajeros
        {
            get => nuevosPasajeros;
            set => nuevosPasajeros = value;
        }
        private void FrmVentaVuelo_Load(object sender, EventArgs e)
        {
            TemaActual(this.tema);
            ListarLosClientes(Sistema.clientes);
            tickets = new List<DataTicket>();
            nuevosPasajeros = new List<Pasajero>();
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
                ListarLosClientes(Sistema.clientes);
            }
        }
        private void FiltrarDatosDeClientes(List<Cliente> filtrado)
        {
            //TODO: sacar de aca mandar a clase sistema
            foreach (Cliente item in Sistema.clientes)
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
            if (this.contadorDeTickets == dtg_CarritoDeCompra.RowCount)
            {
                this.lbl_Error.Text = "Se ha llegado al limite de pasajeros";
                this.lbl_Error.Visible = true;
            }
            else if (this.lst_Clientes.SelectedItem is null && this.vuelo is null)
            {
                this.lbl_Error.Text = "Se ha producido un error en la compra";
                this.lbl_Error.Visible = true;
            }
            else
            {
                this.lbl_Error.Visible = false;
                this.nuevosPasajeros.Add(
                    new Pasajero(
                        ((Cliente)this.lst_Clientes.SelectedItem).Nombre,
                        ((Cliente)this.lst_Clientes.SelectedItem).Apellido,
                        ((Cliente)this.lst_Clientes.SelectedItem).Nacimiento,
                        ((Cliente)this.lst_Clientes.SelectedItem).Dni,
                        ((Cliente)this.lst_Clientes.SelectedItem).Email,
                        VerificarPremium()
                        )
                    );

                tickets.Add(new DataTicket(this.vuelo.ID, (Cliente)this.lst_Clientes.SelectedItem, VerificarPremium(), 11));
                VerificarExiteData();
                FormValidador.ActualizarDataGridVuelos(this.dtg_CarritoDeCompra, tickets);
            }
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
            this.DialogResult = DialogResult.OK;
        }

        private void dtg_CarritoDeCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_CarritoDeCompra.Columns[e.ColumnIndex].Name == "btn_Eliminar")
            {
                tickets.Remove(ObtenerSeleccionado());
                FormValidador.ActualizarDataGridVuelos(dtg_CarritoDeCompra, tickets);
                VerificarExiteData();
            }
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
    }
}
