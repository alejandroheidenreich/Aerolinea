using Entidades;
using Interfaz.FrmCliente;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmInformacionDeLosClientes : Form
    {
        private bool tema;
        public FrmInformacionDeLosClientes(bool temaActual)
        {
            InitializeComponent();
            this.tema = temaActual;
        }

        private void FrmInformacionDeLosClientes_Load(object sender, System.EventArgs e)
        {
            TemaActual(tema);
            dtg_Clientes.DataSource = BaseDeDatos.clientes;
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
            this.btn_AgregarCliente.BackColor = Color.LightGray;
            this.btn_EditarCliente.BackColor = Color.LightGray;
            this.btn_BajaCliente.BackColor = Color.LightGray;
        }
        private void ActivarTemaOscuro()
        {
            this.BackColor = Color.DarkGray;
            this.pic_Lupa.BackColor = Color.DarkGray;
            this.btn_AgregarCliente.BackColor = Color.DimGray;
            this.btn_EditarCliente.BackColor = Color.DimGray;
            this.btn_BajaCliente.BackColor = Color.DimGray;
        }
        private void txt_Buscar_TextChanged_1(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_Buscar.Text))
            {
                List<Cliente> filtrado = new List<Cliente>();
                FiltrarDatosDeClientes(filtrado);
                this.dtg_Clientes.DataSource = filtrado;
            }
            else
            {
                dtg_Clientes.DataSource = BaseDeDatos.clientes;
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
                }else if (item.GetHashCode().ToString().ToUpper().StartsWith(this.txt_Buscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
            }
        }
        private void btbn_AgregarCliente_Click(object sender, System.EventArgs e)
        {
            FrmAltaCliente altaCliente = new FrmAltaCliente(this.tema);

            DialogResult respuesta = altaCliente.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                Sistema.AltaDeCliente(altaCliente.NuevoCliente);
                ActualizarDataGrid(dtg_Clientes, BaseDeDatos.clientes);
            }
        }
        private void btn_BajaCliente_Click(object sender, System.EventArgs e)
        {
            if (this.dtg_Clientes.RowCount == 0)
            {
                this.lbl_Error.Text = "No hay clientes para eliminar";
                this.lbl_Error.Visible = true;
            }
            else
            {
                DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere eliminar al Cliente {dtg_Clientes.CurrentRow.DataBoundItem}?{Environment.NewLine} Esta accion es inrreversible", "Dar Baja a Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (respuesta == DialogResult.Yes)
                {
                    Sistema.BajaDeCliente((Cliente)dtg_Clientes.CurrentRow.DataBoundItem);
                    ActualizarDataGrid(dtg_Clientes, BaseDeDatos.clientes);
                }
            }
        }
        public static void ActualizarDataGrid(DataGridView dtg, List<Cliente> lista)
        {
            dtg.DataSource = null;
            dtg.DataSource = lista;
        }
        private void btn_AgregarCliente_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Agregar Nuevo Cliente", this.btn_AgregarCliente);
        }
        private void btn_BajaCliente_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Dar Baja Cliente", this.btn_BajaCliente);
        }
        private void btn_EditarCliente_Click(object sender, EventArgs e)
        {
            if (this.dtg_Clientes.RowCount == 0)
            {
                this.lbl_Error.Text = "No hay clientes para editar";
                this.lbl_Error.Visible = true;
            }
            else
            {
                FrmEditarCliente editarCliente = new FrmEditarCliente(this.tema, (Cliente)dtg_Clientes.CurrentRow.DataBoundItem);
                DialogResult respuesta = editarCliente.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    ActualizarDataGrid(dtg_Clientes, BaseDeDatos.clientes);
                    MessageBox.Show($"Se ha modificado el cliente {dtg_Clientes.CurrentRow.DataBoundItem}", "Editar Cliente");
                }
            }
        }
    }
}
