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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaVuelo));
            this.lst_Clientes = new System.Windows.Forms.ListBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dtg_CarritoDeCompra = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CarritoDeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_Clientes
            // 
            this.lst_Clientes.BackColor = System.Drawing.Color.DarkGray;
            this.lst_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_Clientes.FormattingEnabled = true;
            this.lst_Clientes.ItemHeight = 16;
            this.lst_Clientes.Location = new System.Drawing.Point(38, 77);
            this.lst_Clientes.Name = "lst_Clientes";
            this.lst_Clientes.Size = new System.Drawing.Size(293, 100);
            this.lst_Clientes.TabIndex = 0;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Buscar.Location = new System.Drawing.Point(38, 48);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(293, 22);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.Text = "Buscar";
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // dtg_CarritoDeCompra
            // 
            this.dtg_CarritoDeCompra.AutoGenerateColumns = false;
            this.dtg_CarritoDeCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.claseDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dtg_CarritoDeCompra.DataSource = this.dataTicketBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_CarritoDeCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_CarritoDeCompra.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_CarritoDeCompra.Location = new System.Drawing.Point(38, 252);
            this.dtg_CarritoDeCompra.MultiSelect = false;
            this.dtg_CarritoDeCompra.Name = "dtg_CarritoDeCompra";
            this.dtg_CarritoDeCompra.ReadOnly = true;
            this.dtg_CarritoDeCompra.RowHeadersVisible = false;
            this.dtg_CarritoDeCompra.RowTemplate.Height = 25;
            this.dtg_CarritoDeCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_CarritoDeCompra.Size = new System.Drawing.Size(733, 277);
            this.dtg_CarritoDeCompra.TabIndex = 2;
            this.dtg_CarritoDeCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CarritoDeCompra_CellContentClick);
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
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.FillWeight = 60.01894F;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.FillWeight = 58.1495F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
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
            this.btn_AgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCliente.Image")));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(337, 20);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(55, 56);
            this.btn_AgregarCliente.TabIndex = 3;
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btn_AgregarCompra
            // 
            this.btn_AgregarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCompra.Image")));
            this.btn_AgregarCompra.Location = new System.Drawing.Point(337, 121);
            this.btn_AgregarCompra.Name = "btn_AgregarCompra";
            this.btn_AgregarCompra.Size = new System.Drawing.Size(55, 56);
            this.btn_AgregarCompra.TabIndex = 4;
            this.btn_AgregarCompra.UseVisualStyleBackColor = true;
            this.btn_AgregarCompra.Click += new System.EventHandler(this.btn_AgregarCompra_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(693, 548);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(103, 58);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Location = new System.Drawing.Point(52, 548);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(127, 58);
            this.btn_Finalizar.TabIndex = 6;
            this.btn_Finalizar.Text = "Finalizar Compra";
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // chk_Clase
            // 
            this.chk_Clase.AutoSize = true;
            this.chk_Clase.Location = new System.Drawing.Point(407, 141);
            this.chk_Clase.Name = "chk_Clase";
            this.chk_Clase.Size = new System.Drawing.Size(75, 19);
            this.chk_Clase.TabIndex = 7;
            this.chk_Clase.Text = "Premium";
            this.chk_Clase.UseVisualStyleBackColor = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Error.Location = new System.Drawing.Point(160, 214);
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
            this.rtb_Facturacion.Size = new System.Drawing.Size(270, 181);
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
            this.btn_Equipaje.Location = new System.Drawing.Point(355, 548);
            this.btn_Equipaje.Name = "btn_Equipaje";
            this.btn_Equipaje.Size = new System.Drawing.Size(127, 58);
            this.btn_Equipaje.TabIndex = 11;
            this.btn_Equipaje.Text = "Agregar Equipaje";
            this.btn_Equipaje.UseVisualStyleBackColor = true;
            this.btn_Equipaje.Click += new System.EventHandler(this.btn_Equipaje_Click);
            // 
            // FrmVentaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 618);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Equipaje);
            this.Controls.Add(this.lbl_EncabezadoFacturacion);
            this.Controls.Add(this.rtb_Facturacion);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.chk_Clase);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_AgregarCompra);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(this.dtg_CarritoDeCompra);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.lst_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentaVuelo";
            this.Load += new System.EventHandler(this.FrmVentaVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CarritoDeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource dataTicketBindingSource1;
        private System.Windows.Forms.RichTextBox rtb_Facturacion;
        private System.Windows.Forms.Label lbl_EncabezadoFacturacion;
        private System.Windows.Forms.Button btn_Equipaje;
    }
}