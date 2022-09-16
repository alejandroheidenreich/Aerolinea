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

namespace Interfaz.FrmCuenta
{
    public partial class FrmVerificarContrasenia : Form
    {
        private Usuario usuario;
        private bool temaActual;
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;

        public FrmVerificarContrasenia(Usuario usuarioActual, bool temaActual)
        {
            InitializeComponent();
            this.usuario = usuarioActual;
            this.temaActual = temaActual;
        }

        private void FrmVerificarContrasenia_Load(object sender, EventArgs e)
        {
            TemaActual(temaActual);
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
            this.pnl_FondoPrincipal.BackColor = Color.WhiteSmoke;
            this.lbl_IngreseContrasenia.BackColor = Color.WhiteSmoke;
            this.txt_Contrasenia.BackColor = Color.WhiteSmoke;
            this.btn_Ingresar.BackColor = Color.WhiteSmoke;
            this.btn_Salir.BackColor = Color.WhiteSmoke;

        }

        private void ActivarDarkMode()
        {
            this.BackColor = Color.SteelBlue;
            this.pnl_FondoPrincipal.BackColor = Color.DarkGray;
            this.lbl_IngreseContrasenia.BackColor = Color.DarkGray;
            this.txt_Contrasenia.BackColor = Color.LightGray;
            this.btn_Ingresar.BackColor = Color.LightGray;
            this.btn_Salir.BackColor = Color.LightGray;
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_FondoPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }

        private void pnl_FondoPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }

        private void pnl_FondoPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }
    }
}
