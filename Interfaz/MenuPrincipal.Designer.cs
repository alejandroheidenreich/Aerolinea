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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pnl_barraInfo = new System.Windows.Forms.Panel();
            this.lbl_InfoUsuarioFecha = new System.Windows.Forms.Label();
            this.lbl_DarkTheme = new System.Windows.Forms.Label();
            this.btn_ToggleTheme = new Interfaz.Controles.BotonToggle();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSecionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_PanelDeFondo = new System.Windows.Forms.Panel();
            this.pic_ImagenDeFondo = new System.Windows.Forms.PictureBox();
            this.pnl_barraInfo.SuspendLayout();
            this.mnu_menuPrincipal.SuspendLayout();
            this.pnl_PanelDeFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagenDeFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_barraInfo
            // 
            this.pnl_barraInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.pnl_barraInfo.Controls.Add(this.lbl_InfoUsuarioFecha);
            this.pnl_barraInfo.Controls.Add(this.lbl_DarkTheme);
            this.pnl_barraInfo.Controls.Add(this.btn_ToggleTheme);
            this.pnl_barraInfo.Location = new System.Drawing.Point(0, 542);
            this.pnl_barraInfo.Name = "pnl_barraInfo";
            this.pnl_barraInfo.Size = new System.Drawing.Size(891, 40);
            this.pnl_barraInfo.TabIndex = 1;
            // 
            // lbl_InfoUsuarioFecha
            // 
            this.lbl_InfoUsuarioFecha.AutoSize = true;
            this.lbl_InfoUsuarioFecha.Location = new System.Drawing.Point(11, 11);
            this.lbl_InfoUsuarioFecha.Name = "lbl_InfoUsuarioFecha";
            this.lbl_InfoUsuarioFecha.Size = new System.Drawing.Size(90, 15);
            this.lbl_InfoUsuarioFecha.TabIndex = 5;
            this.lbl_InfoUsuarioFecha.Text = "Usuario y Fecha";
            // 
            // lbl_DarkTheme
            // 
            this.lbl_DarkTheme.AutoSize = true;
            this.lbl_DarkTheme.Location = new System.Drawing.Point(759, 15);
            this.lbl_DarkTheme.Name = "lbl_DarkTheme";
            this.lbl_DarkTheme.Size = new System.Drawing.Size(70, 15);
            this.lbl_DarkTheme.TabIndex = 4;
            this.lbl_DarkTheme.Text = "Dark Theme";
            // 
            // btn_ToggleTheme
            // 
            this.btn_ToggleTheme.ApagadoCirculoColor = System.Drawing.Color.Ivory;
            this.btn_ToggleTheme.ApagadoSlideColor = System.Drawing.Color.Gray;
            this.btn_ToggleTheme.AutoSize = true;
            this.btn_ToggleTheme.EncendidoCirculoColor = System.Drawing.Color.Chartreuse;
            this.btn_ToggleTheme.EncendidoSlideColor = System.Drawing.Color.Gainsboro;
            this.btn_ToggleTheme.Location = new System.Drawing.Point(835, 11);
            this.btn_ToggleTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.btn_ToggleTheme.Name = "btn_ToggleTheme";
            this.btn_ToggleTheme.Size = new System.Drawing.Size(45, 22);
            this.btn_ToggleTheme.TabIndex = 3;
            this.btn_ToggleTheme.UseVisualStyleBackColor = true;
            this.btn_ToggleTheme.CheckedChanged += new System.EventHandler(this.btn_ToggleTheme_CheckedChanged);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(122, 52);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarCuentaToolStripMenuItem,
            this.cerrarSecionToolStripMenuItem});
            this.cuentaToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cuentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuentaToolStripMenuItem.Image")));
            this.cuentaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(137, 52);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // configurarCuentaToolStripMenuItem
            // 
            this.configurarCuentaToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.configurarCuentaToolStripMenuItem.Name = "configurarCuentaToolStripMenuItem";
            this.configurarCuentaToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.configurarCuentaToolStripMenuItem.Text = "Configurar Cuenta";
            // 
            // cerrarSecionToolStripMenuItem
            // 
            this.cerrarSecionToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cerrarSecionToolStripMenuItem.Name = "cerrarSecionToolStripMenuItem";
            this.cerrarSecionToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.cerrarSecionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSecionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSecionToolStripMenuItem_Click);
            // 
            // mnu_menuPrincipal
            // 
            this.mnu_menuPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.mnu_menuPrincipal.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnu_menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.vuelosToolStripMenuItem,
            this.cuentaToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.mnu_menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnu_menuPrincipal.Name = "mnu_menuPrincipal";
            this.mnu_menuPrincipal.Size = new System.Drawing.Size(891, 56);
            this.mnu_menuPrincipal.TabIndex = 0;
            this.mnu_menuPrincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem1,
            this.cancelacionToolStripMenuItem1});
            this.clientesToolStripMenuItem1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem1.Image")));
            this.clientesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(145, 52);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // informacionToolStripMenuItem1
            // 
            this.informacionToolStripMenuItem1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.informacionToolStripMenuItem1.Name = "informacionToolStripMenuItem1";
            this.informacionToolStripMenuItem1.Size = new System.Drawing.Size(171, 32);
            this.informacionToolStripMenuItem1.Text = "Informacion";
            this.informacionToolStripMenuItem1.Click += new System.EventHandler(this.informacionToolStripMenuItem1_Click);
            // 
            // cancelacionToolStripMenuItem1
            // 
            this.cancelacionToolStripMenuItem1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelacionToolStripMenuItem1.Name = "cancelacionToolStripMenuItem1";
            this.cancelacionToolStripMenuItem1.Size = new System.Drawing.Size(171, 32);
            this.cancelacionToolStripMenuItem1.Text = "Cancelacion";
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeVuelosToolStripMenuItem,
            this.ventaDeVuelosToolStripMenuItem});
            this.vuelosToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vuelosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vuelosToolStripMenuItem.Image")));
            this.vuelosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(135, 52);
            this.vuelosToolStripMenuItem.Text = "Vuelos";
            // 
            // listaDeVuelosToolStripMenuItem
            // 
            this.listaDeVuelosToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listaDeVuelosToolStripMenuItem.Name = "listaDeVuelosToolStripMenuItem";
            this.listaDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.listaDeVuelosToolStripMenuItem.Text = "Lista De Vuelos";
            // 
            // ventaDeVuelosToolStripMenuItem
            // 
            this.ventaDeVuelosToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ventaDeVuelosToolStripMenuItem.Name = "ventaDeVuelosToolStripMenuItem";
            this.ventaDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.ventaDeVuelosToolStripMenuItem.Text = "Venta De Vuelos";
            this.ventaDeVuelosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeVuelosToolStripMenuItem_Click_1);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cerrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarToolStripMenuItem.Image")));
            this.cerrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(131, 52);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // pnl_PanelDeFondo
            // 
            this.pnl_PanelDeFondo.Controls.Add(this.pic_ImagenDeFondo);
            this.pnl_PanelDeFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PanelDeFondo.Location = new System.Drawing.Point(0, 56);
            this.pnl_PanelDeFondo.Name = "pnl_PanelDeFondo";
            this.pnl_PanelDeFondo.Size = new System.Drawing.Size(891, 526);
            this.pnl_PanelDeFondo.TabIndex = 5;
            // 
            // pic_ImagenDeFondo
            // 
            this.pic_ImagenDeFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_ImagenDeFondo.Image = ((System.Drawing.Image)(resources.GetObject("pic_ImagenDeFondo.Image")));
            this.pic_ImagenDeFondo.Location = new System.Drawing.Point(0, 0);
            this.pic_ImagenDeFondo.Name = "pic_ImagenDeFondo";
            this.pic_ImagenDeFondo.Size = new System.Drawing.Size(891, 526);
            this.pic_ImagenDeFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ImagenDeFondo.TabIndex = 0;
            this.pic_ImagenDeFondo.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(891, 582);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_barraInfo);
            this.Controls.Add(this.pnl_PanelDeFondo);
            this.Controls.Add(this.mnu_menuPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_menuPrincipal;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.pnl_barraInfo.ResumeLayout(false);
            this.pnl_barraInfo.PerformLayout();
            this.mnu_menuPrincipal.ResumeLayout(false);
            this.mnu_menuPrincipal.PerformLayout();
            this.pnl_PanelDeFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagenDeFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_barraInfo;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSecionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnu_menuPrincipal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_DarkTheme;
        private Controles.BotonToggle btn_ToggleTheme;
        private System.Windows.Forms.Panel pnl_PanelDeFondo;
        private System.Windows.Forms.PictureBox pic_ImagenDeFondo;
        private System.Windows.Forms.Label lbl_InfoUsuarioFecha;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}