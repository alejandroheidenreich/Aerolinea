namespace Interfaz
{
    partial class FrmAdministracionDeVuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministracionDeVuelos));
            this.dtg_Vuelos = new System.Windows.Forms.DataGridView();
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            this.btn_ExaminarVuelo = new System.Windows.Forms.Button();
            this.btn_EliminarVuelo = new System.Windows.Forms.Button();
            this.pic_Lupa = new System.Windows.Forms.PictureBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_VentaVuelo = new System.Windows.Forms.Button();
            this.tt_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Vuelos
            // 
            this.dtg_Vuelos.AllowUserToAddRows = false;
            this.dtg_Vuelos.AllowUserToDeleteRows = false;
            this.dtg_Vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Vuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Vuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Vuelos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Vuelos.EnableHeadersVisualStyles = false;
            this.dtg_Vuelos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Vuelos.Location = new System.Drawing.Point(71, 96);
            this.dtg_Vuelos.MultiSelect = false;
            this.dtg_Vuelos.Name = "dtg_Vuelos";
            this.dtg_Vuelos.ReadOnly = true;
            this.dtg_Vuelos.RowHeadersVisible = false;
            this.dtg_Vuelos.RowTemplate.Height = 25;
            this.dtg_Vuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Vuelos.Size = new System.Drawing.Size(1387, 588);
            this.dtg_Vuelos.StandardTab = true;
            this.dtg_Vuelos.TabIndex = 0;
            this.dtg_Vuelos.TabStop = false;
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarVuelo.Image")));
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(12, 329);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(53, 50);
            this.btn_AgregarVuelo.TabIndex = 1;
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            this.btn_AgregarVuelo.MouseHover += new System.EventHandler(this.btn_AgregarVuelo_MouseHover);
            // 
            // btn_ExaminarVuelo
            // 
            this.btn_ExaminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExaminarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExaminarVuelo.Image")));
            this.btn_ExaminarVuelo.Location = new System.Drawing.Point(12, 385);
            this.btn_ExaminarVuelo.Name = "btn_ExaminarVuelo";
            this.btn_ExaminarVuelo.Size = new System.Drawing.Size(53, 50);
            this.btn_ExaminarVuelo.TabIndex = 2;
            this.btn_ExaminarVuelo.UseVisualStyleBackColor = true;
            this.btn_ExaminarVuelo.Click += new System.EventHandler(this.btn_ExaminarVuelo_Click);
            this.btn_ExaminarVuelo.MouseHover += new System.EventHandler(this.btn_ExaminarVuelo_MouseHover);
            // 
            // btn_EliminarVuelo
            // 
            this.btn_EliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EliminarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_EliminarVuelo.Image")));
            this.btn_EliminarVuelo.Location = new System.Drawing.Point(12, 441);
            this.btn_EliminarVuelo.Name = "btn_EliminarVuelo";
            this.btn_EliminarVuelo.Size = new System.Drawing.Size(53, 50);
            this.btn_EliminarVuelo.TabIndex = 3;
            this.btn_EliminarVuelo.UseVisualStyleBackColor = true;
            this.btn_EliminarVuelo.Click += new System.EventHandler(this.btn_EliminarVuelo_Click);
            this.btn_EliminarVuelo.MouseHover += new System.EventHandler(this.btn_EliminarVuelo_MouseHover);
            // 
            // pic_Lupa
            // 
            this.pic_Lupa.Image = ((System.Drawing.Image)(resources.GetObject("pic_Lupa.Image")));
            this.pic_Lupa.Location = new System.Drawing.Point(504, 58);
            this.pic_Lupa.Name = "pic_Lupa";
            this.pic_Lupa.Size = new System.Drawing.Size(32, 32);
            this.pic_Lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Lupa.TabIndex = 5;
            this.pic_Lupa.TabStop = false;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Buscar.Location = new System.Drawing.Point(542, 58);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.PlaceholderText = "Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(557, 26);
            this.txt_Buscar.TabIndex = 7;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            this.txt_Buscar.MouseHover += new System.EventHandler(this.txt_Buscar_MouseHover);
            // 
            // btn_VentaVuelo
            // 
            this.btn_VentaVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VentaVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_VentaVuelo.Image")));
            this.btn_VentaVuelo.Location = new System.Drawing.Point(12, 96);
            this.btn_VentaVuelo.Name = "btn_VentaVuelo";
            this.btn_VentaVuelo.Size = new System.Drawing.Size(53, 50);
            this.btn_VentaVuelo.TabIndex = 8;
            this.btn_VentaVuelo.UseVisualStyleBackColor = true;
            this.btn_VentaVuelo.Click += new System.EventHandler(this.btn_VentaVuelo_Click);
            this.btn_VentaVuelo.MouseHover += new System.EventHandler(this.btn_VentaVuelo_MouseHover);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Error.Location = new System.Drawing.Point(103, 51);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(56, 15);
            this.lbl_Error.TabIndex = 9;
            this.lbl_Error.Text = "ERROR";
            this.lbl_Error.Visible = false;
            // 
            // FrmAdministracionDeVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1492, 782);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_VentaVuelo);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.pic_Lupa);
            this.Controls.Add(this.btn_EliminarVuelo);
            this.Controls.Add(this.btn_ExaminarVuelo);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.dtg_Vuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministracionDeVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaDeVuelos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdministracionDeVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Vuelos;
        private System.Windows.Forms.Button btn_AgregarVuelo;
        private System.Windows.Forms.Button btn_ExaminarVuelo;
        private System.Windows.Forms.Button btn_EliminarVuelo;
        private System.Windows.Forms.PictureBox pic_Lupa;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_VentaVuelo;
        private System.Windows.Forms.ToolTip tt_Ayuda;
        private System.Windows.Forms.Label lbl_Error;
    }
}