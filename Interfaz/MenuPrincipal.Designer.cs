namespace Interfaz
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnu_menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaHistoricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSecionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_barraInfo = new System.Windows.Forms.Panel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.mnu_menuPrincipal.SuspendLayout();
            this.pnl_barraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_menuPrincipal
            // 
            this.mnu_menuPrincipal.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnu_menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vuelosToolStripMenuItem,
            this.cuentaToolStripMenuItem});
            this.mnu_menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnu_menuPrincipal.Name = "mnu_menuPrincipal";
            this.mnu_menuPrincipal.Size = new System.Drawing.Size(891, 57);
            this.mnu_menuPrincipal.TabIndex = 0;
            this.mnu_menuPrincipal.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(101, 53);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.ventaDeVuelosToolStripMenuItem,
            this.cancelacionToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(133, 53);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ventaDeVuelosToolStripMenuItem
            // 
            this.ventaDeVuelosToolStripMenuItem.Name = "ventaDeVuelosToolStripMenuItem";
            this.ventaDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(307, 54);
            this.ventaDeVuelosToolStripMenuItem.Text = "Venta de Vuelos";
            this.ventaDeVuelosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeVuelosToolStripMenuItem_Click);
            // 
            // cancelacionToolStripMenuItem
            // 
            this.cancelacionToolStripMenuItem.Name = "cancelacionToolStripMenuItem";
            this.cancelacionToolStripMenuItem.Size = new System.Drawing.Size(307, 54);
            this.cancelacionToolStripMenuItem.Text = "Cancelacion";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(307, 54);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeVuelosToolStripMenuItem,
            this.planDeVuelosToolStripMenuItem,
            this.estadisticaHistoricaToolStripMenuItem});
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(119, 53);
            this.vuelosToolStripMenuItem.Text = "Vuelos";
            // 
            // planDeVuelosToolStripMenuItem
            // 
            this.planDeVuelosToolStripMenuItem.Name = "planDeVuelosToolStripMenuItem";
            this.planDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(359, 54);
            this.planDeVuelosToolStripMenuItem.Text = "Plan de Vuelos";
            this.planDeVuelosToolStripMenuItem.Click += new System.EventHandler(this.planDeVuelosToolStripMenuItem_Click);
            // 
            // estadisticaHistoricaToolStripMenuItem
            // 
            this.estadisticaHistoricaToolStripMenuItem.Name = "estadisticaHistoricaToolStripMenuItem";
            this.estadisticaHistoricaToolStripMenuItem.Size = new System.Drawing.Size(359, 54);
            this.estadisticaHistoricaToolStripMenuItem.Text = "Estadistica Historica";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarCuentaToolStripMenuItem,
            this.cerrarSecionToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(122, 53);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // configurarCuentaToolStripMenuItem
            // 
            this.configurarCuentaToolStripMenuItem.Name = "configurarCuentaToolStripMenuItem";
            this.configurarCuentaToolStripMenuItem.Size = new System.Drawing.Size(332, 54);
            this.configurarCuentaToolStripMenuItem.Text = "Configurar Cuenta";
            // 
            // cerrarSecionToolStripMenuItem
            // 
            this.cerrarSecionToolStripMenuItem.Name = "cerrarSecionToolStripMenuItem";
            this.cerrarSecionToolStripMenuItem.Size = new System.Drawing.Size(332, 54);
            this.cerrarSecionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSecionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSecionToolStripMenuItem_Click);
            // 
            // listaDeVuelosToolStripMenuItem
            // 
            this.listaDeVuelosToolStripMenuItem.Name = "listaDeVuelosToolStripMenuItem";
            this.listaDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(359, 54);
            this.listaDeVuelosToolStripMenuItem.Text = "Lista de Vuelos";
            // 
            // pnl_barraInfo
            // 
            this.pnl_barraInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_barraInfo.Controls.Add(this.lbl_info);
            this.pnl_barraInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_barraInfo.Location = new System.Drawing.Point(0, 542);
            this.pnl_barraInfo.Name = "pnl_barraInfo";
            this.pnl_barraInfo.Size = new System.Drawing.Size(891, 40);
            this.pnl_barraInfo.TabIndex = 1;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(714, 16);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 15);
            this.lbl_info.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 582);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_barraInfo);
            this.Controls.Add(this.mnu_menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnu_menuPrincipal;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.mnu_menuPrincipal.ResumeLayout(false);
            this.mnu_menuPrincipal.PerformLayout();
            this.pnl_barraInfo.ResumeLayout(false);
            this.pnl_barraInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaHistoricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSecionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVuelosToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_barraInfo;
        private System.Windows.Forms.Label lbl_info;
    }
}