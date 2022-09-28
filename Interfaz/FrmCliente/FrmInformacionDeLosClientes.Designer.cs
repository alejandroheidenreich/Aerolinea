namespace Interfaz
{
    partial class FrmInformacionDeLosClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacionDeLosClientes));
            this.dtg_Clientes = new System.Windows.Forms.DataGridView();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pic_Lupa = new System.Windows.Forms.PictureBox();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_BajaCliente = new System.Windows.Forms.Button();
            this.tt_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.btn_EditarCliente = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Clientes
            // 
            this.dtg_Clientes.AllowUserToAddRows = false;
            this.dtg_Clientes.AllowUserToDeleteRows = false;
            this.dtg_Clientes.AllowUserToResizeRows = false;
            this.dtg_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Clientes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Clientes.EnableHeadersVisualStyles = false;
            this.dtg_Clientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Clientes.Location = new System.Drawing.Point(43, 130);
            this.dtg_Clientes.MultiSelect = false;
            this.dtg_Clientes.Name = "dtg_Clientes";
            this.dtg_Clientes.ReadOnly = true;
            this.dtg_Clientes.RowHeadersVisible = false;
            this.dtg_Clientes.RowTemplate.Height = 25;
            this.dtg_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Clientes.Size = new System.Drawing.Size(1405, 583);
            this.dtg_Clientes.TabIndex = 0;
            this.dtg_Clientes.TabStop = false;
            this.dtg_Clientes.VirtualMode = true;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Buscar.Location = new System.Drawing.Point(81, 75);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.PlaceholderText = "Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(401, 26);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged_1);
            // 
            // pic_Lupa
            // 
            this.pic_Lupa.Image = ((System.Drawing.Image)(resources.GetObject("pic_Lupa.Image")));
            this.pic_Lupa.Location = new System.Drawing.Point(43, 69);
            this.pic_Lupa.Name = "pic_Lupa";
            this.pic_Lupa.Size = new System.Drawing.Size(32, 32);
            this.pic_Lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Lupa.TabIndex = 2;
            this.pic_Lupa.TabStop = false;
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCliente.Image")));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(972, 60);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(175, 59);
            this.btn_AgregarCliente.TabIndex = 3;
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btbn_AgregarCliente_Click);
            this.btn_AgregarCliente.MouseHover += new System.EventHandler(this.btn_AgregarCliente_MouseHover);
            // 
            // btn_BajaCliente
            // 
            this.btn_BajaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BajaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_BajaCliente.Image")));
            this.btn_BajaCliente.Location = new System.Drawing.Point(1248, 60);
            this.btn_BajaCliente.Name = "btn_BajaCliente";
            this.btn_BajaCliente.Size = new System.Drawing.Size(59, 59);
            this.btn_BajaCliente.TabIndex = 4;
            this.btn_BajaCliente.UseVisualStyleBackColor = true;
            this.btn_BajaCliente.Click += new System.EventHandler(this.btn_BajaCliente_Click);
            this.btn_BajaCliente.MouseHover += new System.EventHandler(this.btn_BajaCliente_MouseHover);
            // 
            // btn_EditarCliente
            // 
            this.btn_EditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditarCliente.Image")));
            this.btn_EditarCliente.Location = new System.Drawing.Point(1168, 60);
            this.btn_EditarCliente.Name = "btn_EditarCliente";
            this.btn_EditarCliente.Size = new System.Drawing.Size(59, 59);
            this.btn_EditarCliente.TabIndex = 5;
            this.btn_EditarCliente.UseVisualStyleBackColor = true;
            this.btn_EditarCliente.Click += new System.EventHandler(this.btn_EditarCliente_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Error.Location = new System.Drawing.Point(532, 82);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(56, 15);
            this.lbl_Error.TabIndex = 6;
            this.lbl_Error.Text = "ERROR";
            this.lbl_Error.Visible = false;
            // 
            // FrmInformacionDeLosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 782);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_EditarCliente);
            this.Controls.Add(this.btn_BajaCliente);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(this.pic_Lupa);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.dtg_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformacionDeLosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InformacionDeLosPasajeros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInformacionDeLosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Clientes;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.PictureBox pic_Lupa;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_BajaCliente;
        private System.Windows.Forms.ToolTip tt_Ayuda;
        private System.Windows.Forms.Button btn_EditarCliente;
        private System.Windows.Forms.Label lbl_Error;
    }
}