namespace Interfaz.FrmVuelos.FormAdministracion
{
    partial class FrmVentaVuelo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaVuelo));
            this.lst_Clientes = new System.Windows.Forms.ListBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dtg_CarritoDeCompra = new System.Windows.Forms.DataGridView();
            this.dataTicketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_AgregarCompra = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.chk_Clase = new System.Windows.Forms.CheckBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.rtb_Facturacion = new System.Windows.Forms.RichTextBox();
            this.lbl_EncabezadoFacturacion = new System.Windows.Forms.Label();
            this.btn_Equipaje = new System.Windows.Forms.Button();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.lbl_EncabezadoVuelo = new System.Windows.Forms.Label();
            this.tt_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CarritoDeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource)).BeginInit();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Clientes
            // 
            this.lst_Clientes.BackColor = System.Drawing.Color.DarkGray;
            this.lst_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_Clientes.FormattingEnabled = true;
            this.lst_Clientes.ItemHeight = 16;
            this.lst_Clientes.Location = new System.Drawing.Point(26, 109);
            this.lst_Clientes.Name = "lst_Clientes";
            this.lst_Clientes.Size = new System.Drawing.Size(293, 100);
            this.lst_Clientes.TabIndex = 0;
            this.lst_Clientes.MouseHover += new System.EventHandler(this.lst_Clientes_MouseHover);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Buscar.Location = new System.Drawing.Point(26, 81);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.PlaceholderText = "Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(293, 22);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // dtg_CarritoDeCompra
            // 
            this.dtg_CarritoDeCompra.AutoGenerateColumns = false;
            this.dtg_CarritoDeCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_CarritoDeCompra.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_CarritoDeCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_CarritoDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CarritoDeCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clienteDataGridViewTextBoxColumn,
            this.claseDataGridViewTextBoxColumn});
            this.dtg_CarritoDeCompra.DataSource = this.dataTicketBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_CarritoDeCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_CarritoDeCompra.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_CarritoDeCompra.Location = new System.Drawing.Point(38, 288);
            this.dtg_CarritoDeCompra.MultiSelect = false;
            this.dtg_CarritoDeCompra.Name = "dtg_CarritoDeCompra";
            this.dtg_CarritoDeCompra.ReadOnly = true;
            this.dtg_CarritoDeCompra.RowHeadersVisible = false;
            this.dtg_CarritoDeCompra.RowTemplate.Height = 25;
            this.dtg_CarritoDeCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_CarritoDeCompra.Size = new System.Drawing.Size(733, 318);
            this.dtg_CarritoDeCompra.TabIndex = 5;
            this.dtg_CarritoDeCompra.TabStop = false;
            this.dtg_CarritoDeCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CarritoDeCompra_CellContentClick);
            // 
            // dataTicketBindingSource1
            // 
            this.dataTicketBindingSource1.DataSource = typeof(Interfaz.DataTicket);
            // 
            // dataTicketBindingSource
            // 
            this.dataTicketBindingSource.DataSource = typeof(Interfaz.DataTicket);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCliente.Image")));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(325, 81);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(55, 56);
            this.btn_AgregarCliente.TabIndex = 2;
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            this.btn_AgregarCliente.MouseHover += new System.EventHandler(this.btn_AgregarCliente_MouseHover);
            // 
            // btn_AgregarCompra
            // 
            this.btn_AgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCompra.Image")));
            this.btn_AgregarCompra.Location = new System.Drawing.Point(325, 153);
            this.btn_AgregarCompra.Name = "btn_AgregarCompra";
            this.btn_AgregarCompra.Size = new System.Drawing.Size(55, 56);
            this.btn_AgregarCompra.TabIndex = 3;
            this.btn_AgregarCompra.UseVisualStyleBackColor = true;
            this.btn_AgregarCompra.Click += new System.EventHandler(this.btn_AgregarCompra_Click);
            this.btn_AgregarCompra.MouseHover += new System.EventHandler(this.btn_AgregarCompra_MouseHover);
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(809, 611);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(40, 40);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Finalizar.Image")));
            this.btn_Finalizar.Location = new System.Drawing.Point(777, 48);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(62, 218);
            this.btn_Finalizar.TabIndex = 7;
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            this.btn_Finalizar.MouseHover += new System.EventHandler(this.btn_Finalizar_MouseHover);
            // 
            // chk_Clase
            // 
            this.chk_Clase.AutoSize = true;
            this.chk_Clase.Location = new System.Drawing.Point(386, 173);
            this.chk_Clase.Name = "chk_Clase";
            this.chk_Clase.Size = new System.Drawing.Size(75, 19);
            this.chk_Clase.TabIndex = 4;
            this.chk_Clase.Text = "Premium";
            this.chk_Clase.UseVisualStyleBackColor = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Error.Location = new System.Drawing.Point(64, 239);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(39, 15);
            this.lbl_Error.TabIndex = 8;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // rtb_Facturacion
            // 
            this.rtb_Facturacion.Location = new System.Drawing.Point(501, 48);
            this.rtb_Facturacion.Name = "rtb_Facturacion";
            this.rtb_Facturacion.ReadOnly = true;
            this.rtb_Facturacion.Size = new System.Drawing.Size(270, 218);
            this.rtb_Facturacion.TabIndex = 9;
            this.rtb_Facturacion.Text = "";
            // 
            // lbl_EncabezadoFacturacion
            // 
            this.lbl_EncabezadoFacturacion.AutoSize = true;
            this.lbl_EncabezadoFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoFacturacion.Location = new System.Drawing.Point(501, 30);
            this.lbl_EncabezadoFacturacion.Name = "lbl_EncabezadoFacturacion";
            this.lbl_EncabezadoFacturacion.Size = new System.Drawing.Size(88, 16);
            this.lbl_EncabezadoFacturacion.TabIndex = 10;
            this.lbl_EncabezadoFacturacion.Text = "Facturacion";
            // 
            // btn_Equipaje
            // 
            this.btn_Equipaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Equipaje.Image = ((System.Drawing.Image)(resources.GetObject("btn_Equipaje.Image")));
            this.btn_Equipaje.Location = new System.Drawing.Point(777, 306);
            this.btn_Equipaje.Name = "btn_Equipaje";
            this.btn_Equipaje.Size = new System.Drawing.Size(62, 300);
            this.btn_Equipaje.TabIndex = 6;
            this.btn_Equipaje.UseVisualStyleBackColor = true;
            this.btn_Equipaje.Click += new System.EventHandler(this.btn_Equipaje_Click);
            this.btn_Equipaje.MouseHover += new System.EventHandler(this.btn_Equipaje_MouseHover);
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoVuelo);
            this.pnl_Fondo.Controls.Add(this.btn_Salir);
            this.pnl_Fondo.Controls.Add(this.lbl_Error);
            this.pnl_Fondo.Controls.Add(this.lst_Clientes);
            this.pnl_Fondo.Controls.Add(this.chk_Clase);
            this.pnl_Fondo.Controls.Add(this.btn_AgregarCliente);
            this.pnl_Fondo.Controls.Add(this.btn_AgregarCompra);
            this.pnl_Fondo.Controls.Add(this.txt_Buscar);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(852, 654);
            this.pnl_Fondo.TabIndex = 12;
            this.pnl_Fondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseDown);
            this.pnl_Fondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseMove);
            this.pnl_Fondo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseUp);
            // 
            // lbl_EncabezadoVuelo
            // 
            this.lbl_EncabezadoVuelo.AutoSize = true;
            this.lbl_EncabezadoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoVuelo.Location = new System.Drawing.Point(26, 19);
            this.lbl_EncabezadoVuelo.Name = "lbl_EncabezadoVuelo";
            this.lbl_EncabezadoVuelo.Size = new System.Drawing.Size(45, 16);
            this.lbl_EncabezadoVuelo.TabIndex = 9;
            this.lbl_EncabezadoVuelo.Text = "vuelo";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Registro";
            this.Column1.HeaderText = "Registro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.FillWeight = 60.01894F;
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claseDataGridViewTextBoxColumn
            // 
            this.claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            this.claseDataGridViewTextBoxColumn.FillWeight = 60.01894F;
            this.claseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
            this.claseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmVentaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(876, 678);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Equipaje);
            this.Controls.Add(this.lbl_EncabezadoFacturacion);
            this.Controls.Add(this.rtb_Facturacion);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.dtg_CarritoDeCompra);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentaVuelo";
            this.Load += new System.EventHandler(this.FrmVentaVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CarritoDeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource)).EndInit();
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Clientes;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView dtg_CarritoDeCompra;
        private System.Windows.Forms.BindingSource dataTicketBindingSource;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_AgregarCompra;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.CheckBox chk_Clase;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTicketBindingSource1;
        private System.Windows.Forms.RichTextBox rtb_Facturacion;
        private System.Windows.Forms.Label lbl_EncabezadoFacturacion;
        private System.Windows.Forms.Button btn_Equipaje;
        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label lbl_EncabezadoVuelo;
        private System.Windows.Forms.ToolTip tt_Ayuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
    }
}