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

namespace Interfaz.FrmPasajeros
{
    public partial class FrmAltaEquipaje : Form
    {
        private bool equipajeDeMano;
        private List<double>? equipajesBodega;


        public FrmAltaEquipaje()
        {
            InitializeComponent();
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
            if (nud_PesoEquipaje.Value > 0)
            {
                this.equipajesBodega.Add((double)nud_PesoEquipaje.Value);
                ActualizarListBox();
            }
            else
            {
                lbl_Error.Text = "El equipaje debe tener un Peso";
                lbl_Error.Visible = true;
            }
        }

        private void ActualizarListBox()
        {
            lst_Equipajes.Items.Clear();
            OrdenarEquipaje();
            foreach (double item in this.equipajesBodega)
            {
                lst_Equipajes.Items.Add($"Equipaje de Bodega ({item.ToString("0.###")}) KG.");
            }
            //lst_Equipajes.DataSource = this.equipajesBodega;
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
    }
}
