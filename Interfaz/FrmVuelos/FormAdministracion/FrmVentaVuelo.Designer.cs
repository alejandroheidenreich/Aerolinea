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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaVuelo));
            this.lst_Clientes = new System.Windows.Forms.ListBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dtg_CarritoDeCompra = new System.Windows.Forms.DataGridView();
            this.dataTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_AgregarCompra = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.chk_Clase = new System.Windows.Forms.CheckBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CarritoDeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_Clientes
            // 
            this.lst_Clientes.FormattingEnabled = true;
            this.lst_Clientes.ItemHeight = 15;
            this.lst_Clientes.Location = new System.Drawing.Point(87, 77);
            this.lst_Clientes.Name = "lst_Clientes";
            this.lst_Clientes.Size = new System.Drawing.Size(187, 109);
            this.lst_Clientes.TabIndex = 0;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(87, 39);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(187, 23);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.Text = "Buscar";
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // dtg_CarritoDeCompra
            // 
            this.dtg_CarritoDeCompra.AutoGenerateColumns = false;
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
            this.idDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.claseDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dtg_CarritoDeCompra.DataSource = this.dataTicketBindingSource;
            this.dtg_CarritoDeCompra.Location = new System.Drawing.Point(87, 236);
            this.dtg_CarritoDeCompra.Name = "dtg_CarritoDeCompra";
            this.dtg_CarritoDeCompra.RowHeadersVisible = false;
            this.dtg_CarritoDeCompra.RowTemplate.Height = 25;
            this.dtg_CarritoDeCompra.Size = new System.Drawing.Size(478, 150);
            this.dtg_CarritoDeCompra.TabIndex = 2;
            this.dtg_CarritoDeCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CarritoDeCompra_CellContentClick);
            // 
            // dataTicketBindingSource
            // 
            this.dataTicketBindingSource.DataSource = typeof(Interfaz.DataTicket);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claseDataGridViewTextBoxColumn
            // 
            this.claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            this.claseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
            this.claseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "Id";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 75;
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCliente.Image")));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(280, 55);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(55, 56);
            this.btn_AgregarCliente.TabIndex = 3;
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btn_AgregarCompra
            // 
            this.btn_AgregarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCompra.Image")));
            this.btn_AgregarCompra.Location = new System.Drawing.Point(280, 130);
            this.btn_AgregarCompra.Name = "btn_AgregarCompra";
            this.btn_AgregarCompra.Size = new System.Drawing.Size(55, 56);
            this.btn_AgregarCompra.TabIndex = 4;
            this.btn_AgregarCompra.UseVisualStyleBackColor = true;
            this.btn_AgregarCompra.Click += new System.EventHandler(this.btn_AgregarCompra_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(38, 408);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(103, 58);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Location = new System.Drawing.Point(167, 408);
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
            this.chk_Clase.Location = new System.Drawing.Point(341, 150);
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
            this.lbl_Error.Location = new System.Drawing.Point(296, 208);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(39, 15);
            this.lbl_Error.TabIndex = 8;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // FrmVentaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 498);
            this.ControlBox = false;
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
            this.Name = "FrmVentaVuelo";
            this.Text = "FrmVentaVuelo";
            this.Load += new System.EventHandler(this.FrmVentaVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CarritoDeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Clientes;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView dtg_CarritoDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource dataTicketBindingSource;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_AgregarCompra;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.CheckBox chk_Clase;
        private System.Windows.Forms.Label lbl_Error;
    }
}