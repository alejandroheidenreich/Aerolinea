using Entidades;
using Interfaz.FrmCliente;
using Interfaz.FrmPasajeros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IronXL;

namespace Interfaz.FrmVuelos.FormAdministracion
{
    public partial class FrmVentaVuelo : Form
    {
        private Vuelo vuelo;
        private List<DataTicket>? tickets;
        private List<Pasaje>? nuevosPasajeros;
        private bool tema;
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;

        public FrmVentaVuelo(Vuelo vuelo, bool temaActual)
        {
            InitializeComponent();
            this.tema = temaActual;
            this.vuelo = vuelo;
            this.lbl_EncabezadoVuelo.Text = vuelo.ToString();
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
            this.btn_AgregarCliente.BackColor = Color.LightGray;
            this.btn_Equipaje.BackColor = Color.LightGray;
            this.btn_AgregarCompra.BackColor = Color.LightGray;
            this.btn_Finalizar.BackColor = Color.LightGray;
            this.btn_Salir.BackColor = Color.LightGray;
            this.dtg_CarritoDeCompra.DefaultCellStyle.BackColor = Color.LightGray;
            this.lst_Clientes.BackColor = Color.DarkGray;
            this.rtb_Facturacion.BackColor = Color.DarkGray;
            this.chk_Clase.BackColor = Color.WhiteSmoke;
            this.lbl_Error.BackColor = Color.WhiteSmoke;
            this.lbl_EncabezadoFacturacion.BackColor = Color.WhiteSmoke;
        }
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_AgregarCliente.BackColor = Color.DimGray;
            this.btn_Equipaje.BackColor = Color.DimGray;
            this.btn_AgregarCompra.BackColor = Color.DimGray;
            this.btn_Finalizar.BackColor = Color.DimGray;
            this.btn_Salir.BackColor = Color.DimGray;
            this.dtg_CarritoDeCompra.DefaultCellStyle.BackColor = Color.DarkGray;
            this.lst_Clientes.BackColor = Color.DarkGray;
            this.rtb_Facturacion.BackColor = Color.DarkGray;
            this.chk_Clase.BackColor = Color.DarkGray;
            this.lbl_Error.BackColor = Color.DarkGray;
            this.lbl_EncabezadoFacturacion.BackColor = Color.DarkGray;
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
                else if (item.GetHashCode().ToString().ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }

            }
        }
        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente altaCliente = new FrmAltaCliente(this.tema);

            DialogResult respuesta = altaCliente.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                Sistema.AltaDeCliente(altaCliente.NuevoCliente);
            }
        }

        private void btn_AgregarCompra_Click(object sender, EventArgs e)
        {
            if (this.lst_Clientes.SelectedItem is null)
            {
                this.lbl_Error.Text = "Porfavor seleccione un cliente";
                this.lbl_Error.Visible = true;
            }
            else
            {
                Pasaje pasajeAgregado = new Pasaje((Cliente)lst_Clientes.SelectedItem, VerificarPremium());
                this.lbl_Error.Visible = false;
                try
                {
                    Sistema.ValidadCompraDeClase(this.vuelo, pasajeAgregado, this.nuevosPasajeros);
                    if (Sistema.VerificarPasajeComprar(this.vuelo, pasajeAgregado, this.nuevosPasajeros))
                    {
                        AgregarVuelo(pasajeAgregado);
                    }
                    else
                    {
                        this.lbl_Error.Text = "El pasajero alcanzo el limite de pasajes por vuelo";
                        this.lbl_Error.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    this.lbl_Error.Text = ex.Message;
                    this.lbl_Error.Visible = true;

                }
            }
        }

        private void AgregarVuelo(Pasaje pasajeAgregado)
        {
            double precioFinal;
            this.nuevosPasajeros.Add(pasajeAgregado);
            this.vuelo.InformarConPrecioDelPasaje(pasajeAgregado, out precioFinal);
            tickets.Add(new DataTicket(pasajeAgregado.IdRegistro, (Cliente)this.lst_Clientes.SelectedItem, VerificarPremium(), precioFinal));
            ActualizarFacturacionActual();
            VerificarExiteData();
            ActualizarDataGrid(this.dtg_CarritoDeCompra, tickets);
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
            sb.AppendLine($"Precio Final Neto (+IVA): $ {(precioFinal * 1.21).ToString("0.00")} U$D");

            rtb_Facturacion.Text = sb.ToString();
        }

        private string GenerarRegsitro()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] matriculaArray = new char[6];
            Random random = new Random();

            for (int i = 0; i < matriculaArray.Length; i++)
            {
                matriculaArray[i] = caracteres[random.Next(caracteres.Length)];
            }
            return new String(matriculaArray);
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
                if (this.nuevosPasajeros.Count != 0)
                {
                    GenerarTicket();

                    Sistema.AltaDePasajero(this.nuevosPasajeros, this.vuelo);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.lbl_Error.Text = "La facturacion esta vacia";
                    this.lbl_Error.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerarTicket()
        {
            WorkBook archivo = WorkBook.Create(ExcelFileFormat.XLSX);
            WorkSheet hoja = archivo.CreateWorkSheet("ticket");
            string ticket = GenerarRegsitro();
            double precioPremium;
            double precioPeso;
            double precioFinal = 0;
            double horasTotales = vuelo.CalcularHorasTotales();
            double precioBase = vuelo.PrecioSegunTipoDeVuelo(horasTotales);
            int fila = 1;

            hoja["A1"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            hoja["A1"].Style.Font.Bold = true;
            hoja["A1"].Value = $"Ticket {ticket}";

            for (int i = 0; i < this.nuevosPasajeros.Count; i++)
            {
                precioFinal += precioBase;
                fila++;
                hoja[$"A{fila}"].Value = $"Registro: {this.nuevosPasajeros[i].IdRegistro}";
                fila++;
                hoja[$"A{fila}"].Value = $"Preio Bruto: $ {precioBase.ToString("0.00")} USD";
                if (this.nuevosPasajeros[i].Clase == ClaseDePasajero.Premium)
                {
                    fila++;
                    precioPremium = vuelo.CalcularAdicionalPremium(precioBase);
                    precioFinal += precioPremium;
                    hoja[$"A{fila}"].Value = $"Impuesto por Premium: $ {precioPremium.ToString("0.00")} USD";
                }
                if (this.nuevosPasajeros[i].PesoAdicional > 0)
                {
                    fila++;
                    precioPeso = vuelo.CalcularAdicionalPeso(precioBase, this.nuevosPasajeros[i].PesoAdicional);
                    precioFinal += precioPeso;
                    hoja[$"A{fila}"].Value = $"Impuesto por Peso Adicional: $ {precioPeso.ToString("0.00")} USD";
                }
                fila++;
            }
            hoja[$"A{fila}"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            fila++;
            hoja[$"A{fila}"].Style.Font.Bold = true;
            hoja[$"A{fila}"].Value = $"Precio Fianl Neto (+IVA): $ {(precioFinal*1.21).ToString("0.00")} USD";
            archivo.SaveAs($"Ticket {ticket}.xlsx");
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
                btn_Equipaje.Visible = false;
                this.rtb_Facturacion.Clear();
            }
            else
            {
                dtg_CarritoDeCompra.Visible = true;
                btn_Equipaje.Visible = true;
            }
        }

        private void btn_Equipaje_Click(object sender, EventArgs e)
        {
            if (dtg_CarritoDeCompra.Visible && dtg_CarritoDeCompra.CurrentRow.DataBoundItem is not null)
            {
                Pasaje pasajeAgregarEquipaje = EncontrarPasaje(ObtenerSeleccionado().Registro);
                FrmAltaEquipaje frmEquipaje = new FrmAltaEquipaje(this.vuelo, this.tema, pasajeAgregarEquipaje);
                DialogResult respuesta = frmEquipaje.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    pasajeAgregarEquipaje.EquipajeDeMano = frmEquipaje.EquipajeDeMano;
                    foreach (double item in frmEquipaje.EquipajesBodega)
                    {
                        pasajeAgregarEquipaje.AgregarEquipaje(item);
                    }
                    ActualizarFacturacionActual();
                }
            }
            else
            {
                this.lbl_Error.Text = "Debe seleccionar un Pasajero Registrado";
                this.lbl_Error.Visible = true;
            }
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

        private void btn_AgregarCompra_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Agregar a Compra", this.btn_AgregarCompra);
        }

        private void btn_AgregarCliente_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Agregar Nuevo Cliente", this.btn_AgregarCliente);
        }

        private void btn_Finalizar_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Terminar Operacion", this.btn_Finalizar);
        }

        private void btn_Equipaje_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Añadir Equipaje al Pasajero", this.btn_Equipaje);
        }

        private void lst_Clientes_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Seleccionar Cliente a Vender Pasaje", this.lst_Clientes);
        }
    }
}
