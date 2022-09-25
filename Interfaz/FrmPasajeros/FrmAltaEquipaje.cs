using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz.FrmPasajeros
{
    public partial class FrmAltaEquipaje : Form
    {
        private bool equipajeDeMano;
        private List<double>? equipajesBodega;
        private Vuelo vuelo;
        private bool tema;
        private Cliente cliente;
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;
        public FrmAltaEquipaje(Vuelo vuelo, bool tema, Cliente cliente)
        {
            InitializeComponent();
            this.vuelo = vuelo;
            this.tema = tema;
            this.cliente = cliente;
        }
        public bool EquipajeDeMano
        {
            get => equipajeDeMano;
        }
        public List<double>? EquipajesBodega
        {
            get => equipajesBodega;
        }
        private void FrmAltaEquipaje_Load(object sender, EventArgs e)
        {
            equipajesBodega = new List<double>();
            this.equipajeDeMano = false;
            this.TemaActual(this.tema);
            this.lbl_EncabezadoCliente.Text = $"Equipaje del cliente:{Environment.NewLine}{this.cliente.ToString()}";
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
            this.BackColor = Color.SkyBlue;
            this.pnl_Fondo.BackColor = Color.WhiteSmoke;
            this.btn_AgregarEquipaje.BackColor = Color.LightGray;
            this.btn_Cancelar.BackColor = Color.LightGray;
            this.btn_Confirmar.BackColor = Color.LightGray;
            this.btn_Eliminar.BackColor = Color.LightGray;
            this.lbl_EncabezadoPeso.BackColor = Color.WhiteSmoke;
            this.lbl_Error.BackColor = Color.WhiteSmoke;
            this.lbl_KG.BackColor = Color.WhiteSmoke;
            this.lst_Equipajes.BackColor = Color.LightGray;
            this.chk_EquipajeDeMano.BackColor = Color.WhiteSmoke;
            this.lbl_Error.BackColor = Color.WhiteSmoke;
            this.chk_EquipajeDeMano.BackColor = Color.WhiteSmoke;
        }


        private void ActivarDarkMode()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_Fondo.BackColor = Color.DarkGray;
            this.btn_AgregarEquipaje.BackColor = Color.DimGray;
            this.btn_Cancelar.BackColor = Color.DimGray;
            this.btn_Confirmar.BackColor = Color.DimGray;
            this.btn_Eliminar.BackColor = Color.DimGray;
            this.lbl_EncabezadoPeso.BackColor = Color.DarkGray;
            this.lbl_Error.BackColor = Color.DarkGray;
            this.lbl_KG.BackColor = Color.DarkGray;
            this.lst_Equipajes.BackColor = Color.DimGray;
            this.chk_EquipajeDeMano.BackColor = Color.DarkGray;
            this.lbl_Error.BackColor = Color.DarkGray;
            this.chk_EquipajeDeMano.BackColor = Color.DarkGray;
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void chk_EquipajeDeMano_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_EquipajeDeMano.Checked)
            {
                this.equipajeDeMano = true;
            }
            else
            {
                this.equipajeDeMano = false;
            }
        }

        private void btn_AgregarEquipaje_Click(object sender, EventArgs e)
        {
            if (nud_PesoEquipaje.Value < 0)
            {
                lbl_Error.Text = "El equipaje debe tener un Peso";
                lbl_Error.Visible = true;
            }
            else if ((double)nud_PesoEquipaje.Value > this.vuelo.EspacioDisponibleBodega())
            {
                lbl_Error.Text = $"La aeronave solo tiene {this.vuelo.EspacioDisponibleBodega()} disponible";
                lbl_Error.Visible = true;
            }
            else
            {
                lbl_Error.Visible = false;
                this.equipajesBodega.Add((double)nud_PesoEquipaje.Value);
                ActualizarListBox();
            }
        }

        private void ActualizarListBox()
        {
            lst_Equipajes.Items.Clear();
            OrdenarEquipaje();
            foreach (double item in this.equipajesBodega)
            {
                lst_Equipajes.Items.Add($"Equipaje de Bodega ({item.ToString("0.000")}) KG.");
            }
        }

        private void nud_PesoEquipaje_ValueChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
        }

        private void OrdenarEquipaje()
        {
            double aux;
            for (int i = 0; i < this.equipajesBodega.Count; i++)
            {
                for (int j = 0; j < this.equipajesBodega.Count; j++)
                {
                    if (this.equipajesBodega[i] > this.equipajesBodega[j])
                    {
                        aux = this.equipajesBodega[i];
                        this.equipajesBodega[i] = this.equipajesBodega[j];
                        this.equipajesBodega[j] = aux;
                    }
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Equipajes.SelectedIndex is not -1)
            {
                this.equipajesBodega.RemoveAt(lst_Equipajes.SelectedIndex);
                ActualizarListBox();
            }
            else
            {
                lbl_Error.Text = "Debe seleccionar un equipaje para borrarlo";
                lbl_Error.Visible = true;
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

        private void btn_AgregarEquipaje_MouseHover(object sender, EventArgs e)
        {
            this.tt_Ayuda.Show("Añadir Equipaje", this.btn_AgregarEquipaje);
        }
    }
}
