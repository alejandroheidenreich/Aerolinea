namespace Interfaz.FrmVuelos.FormAdministracion
{
    partial class FrmAeronaves
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Aeronaves = new System.Windows.Forms.DataGridView();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Aeronaves)).BeginInit();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Aeronaves
            // 
            this.dtg_Aeronaves.AllowUserToAddRows = false;
            this.dtg_Aeronaves.AllowUserToDeleteRows = false;
            this.dtg_Aeronaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Aeronaves.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Aeronaves.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Aeronaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Aeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Aeronaves.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Aeronaves.EnableHeadersVisualStyles = false;
            this.dtg_Aeronaves.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Aeronaves.Location = new System.Drawing.Point(16, 44);
            this.dtg_Aeronaves.MultiSelect = false;
            this.dtg_Aeronaves.Name = "dtg_Aeronaves";
            this.dtg_Aeronaves.ReadOnly = true;
            this.dtg_Aeronaves.RowHeadersVisible = false;
            this.dtg_Aeronaves.RowTemplate.Height = 25;
            this.dtg_Aeronaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Aeronaves.Size = new System.Drawing.Size(675, 230);
            this.dtg_Aeronaves.TabIndex = 0;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Seleccionar.Location = new System.Drawing.Point(214, 289);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(299, 51);
            this.btn_Seleccionar.TabIndex = 1;
            this.btn_Seleccionar.Text = "SELECCIONAR";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(643, 315);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 48);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Fondo.Controls.Add(this.btn_Seleccionar);
            this.pnl_Fondo.Controls.Add(this.btn_Salir);
            this.pnl_Fondo.Controls.Add(this.dtg_Aeronaves);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(706, 374);
            this.pnl_Fondo.TabIndex = 3;
            this.pnl_Fondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseDown);
            this.pnl_Fondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseMove);
            this.pnl_Fondo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseUp);
            // 
            // FrmAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(730, 401);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAeronaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAeronaves";
            this.Load += new System.EventHandler(this.FrmAeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Aeronaves)).EndInit();
            this.pnl_Fondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Aeronaves;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel pnl_Fondo;
    }
}