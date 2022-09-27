namespace Interfaz.FrmVuelos.FormAdministracion
{
    partial class FrmInformacionDeVuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacionDeVuelos));
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.lbl_TipoDeVuelo = new System.Windows.Forms.Label();
            this.lbl_Duracion = new System.Windows.Forms.Label();
            this.lbl_Partida = new System.Windows.Forms.Label();
            this.dtg_ListaDePasajeros = new System.Windows.Forms.DataGridView();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_Aeronave = new System.Windows.Forms.Label();
            this.lbl_EncabezadoAeronave = new System.Windows.Forms.Label();
            this.pnl_Aeronave = new System.Windows.Forms.Panel();
            this.lbl_Turista = new System.Windows.Forms.Label();
            this.lbl_Premium = new System.Windows.Forms.Label();
            this.lbl_DispoBodega = new System.Windows.Forms.Label();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaDePasajeros)).BeginInit();
            this.pnl_Aeronave.SuspendLayout();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Origen.Location = new System.Drawing.Point(114, 71);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(53, 20);
            this.lbl_Origen.TabIndex = 0;
            this.lbl_Origen.Text = "origen";
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Destino.Location = new System.Drawing.Point(349, 71);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(61, 20);
            this.lbl_Destino.TabIndex = 1;
            this.lbl_Destino.Text = "destino";
            // 
            // lbl_TipoDeVuelo
            // 
            this.lbl_TipoDeVuelo.AutoSize = true;
            this.lbl_TipoDeVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoDeVuelo.Location = new System.Drawing.Point(247, 38);
            this.lbl_TipoDeVuelo.Name = "lbl_TipoDeVuelo";
            this.lbl_TipoDeVuelo.Size = new System.Drawing.Size(35, 20);
            this.lbl_TipoDeVuelo.TabIndex = 2;
            this.lbl_TipoDeVuelo.Text = "tipo";
            // 
            // lbl_Duracion
            // 
            this.lbl_Duracion.AutoSize = true;
            this.lbl_Duracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Duracion.Location = new System.Drawing.Point(788, 71);
            this.lbl_Duracion.Name = "lbl_Duracion";
            this.lbl_Duracion.Size = new System.Drawing.Size(70, 20);
            this.lbl_Duracion.TabIndex = 3;
            this.lbl_Duracion.Text = "duracion";
            // 
            // lbl_Partida
            // 
            this.lbl_Partida.AutoSize = true;
            this.lbl_Partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Partida.Location = new System.Drawing.Point(565, 71);
            this.lbl_Partida.Name = "lbl_Partida";
            this.lbl_Partida.Size = new System.Drawing.Size(58, 20);
            this.lbl_Partida.TabIndex = 4;
            this.lbl_Partida.Text = "partida";
            // 
            // dtg_ListaDePasajeros
            // 
            this.dtg_ListaDePasajeros.AllowUserToAddRows = false;
            this.dtg_ListaDePasajeros.AllowUserToDeleteRows = false;
            this.dtg_ListaDePasajeros.AllowUserToOrderColumns = true;
            this.dtg_ListaDePasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ListaDePasajeros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_ListaDePasajeros.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ListaDePasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_ListaDePasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_ListaDePasajeros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_ListaDePasajeros.EnableHeadersVisualStyles = false;
            this.dtg_ListaDePasajeros.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_ListaDePasajeros.Location = new System.Drawing.Point(29, 130);
            this.dtg_ListaDePasajeros.MultiSelect = false;
            this.dtg_ListaDePasajeros.Name = "dtg_ListaDePasajeros";
            this.dtg_ListaDePasajeros.ReadOnly = true;
            this.dtg_ListaDePasajeros.RowHeadersVisible = false;
            this.dtg_ListaDePasajeros.RowTemplate.Height = 25;
            this.dtg_ListaDePasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ListaDePasajeros.Size = new System.Drawing.Size(612, 451);
            this.dtg_ListaDePasajeros.TabIndex = 5;
            // 
            // btn_Atras
            // 
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(15, 12);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(53, 46);
            this.btn_Atras.TabIndex = 7;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_Aeronave
            // 
            this.lbl_Aeronave.AutoSize = true;
            this.lbl_Aeronave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Aeronave.Location = new System.Drawing.Point(12, 69);
            this.lbl_Aeronave.Name = "lbl_Aeronave";
            this.lbl_Aeronave.Size = new System.Drawing.Size(46, 20);
            this.lbl_Aeronave.TabIndex = 8;
            this.lbl_Aeronave.Text = "avion";
            // 
            // lbl_EncabezadoAeronave
            // 
            this.lbl_EncabezadoAeronave.AutoSize = true;
            this.lbl_EncabezadoAeronave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoAeronave.Location = new System.Drawing.Point(101, 23);
            this.lbl_EncabezadoAeronave.Name = "lbl_EncabezadoAeronave";
            this.lbl_EncabezadoAeronave.Size = new System.Drawing.Size(77, 20);
            this.lbl_EncabezadoAeronave.TabIndex = 9;
            this.lbl_EncabezadoAeronave.Text = "Aeronave";
            // 
            // pnl_Aeronave
            // 
            this.pnl_Aeronave.Controls.Add(this.lbl_Turista);
            this.pnl_Aeronave.Controls.Add(this.lbl_Premium);
            this.pnl_Aeronave.Controls.Add(this.lbl_DispoBodega);
            this.pnl_Aeronave.Controls.Add(this.lbl_Aeronave);
            this.pnl_Aeronave.Controls.Add(this.lbl_EncabezadoAeronave);
            this.pnl_Aeronave.Location = new System.Drawing.Point(647, 130);
            this.pnl_Aeronave.Name = "pnl_Aeronave";
            this.pnl_Aeronave.Size = new System.Drawing.Size(310, 274);
            this.pnl_Aeronave.TabIndex = 13;
            // 
            // lbl_Turista
            // 
            this.lbl_Turista.AutoSize = true;
            this.lbl_Turista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Turista.Location = new System.Drawing.Point(13, 229);
            this.lbl_Turista.Name = "lbl_Turista";
            this.lbl_Turista.Size = new System.Drawing.Size(53, 20);
            this.lbl_Turista.TabIndex = 16;
            this.lbl_Turista.Text = "turista";
            // 
            // lbl_Premium
            // 
            this.lbl_Premium.AutoSize = true;
            this.lbl_Premium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Premium.Location = new System.Drawing.Point(13, 209);
            this.lbl_Premium.Name = "lbl_Premium";
            this.lbl_Premium.Size = new System.Drawing.Size(70, 20);
            this.lbl_Premium.TabIndex = 15;
            this.lbl_Premium.Text = "premium";
            // 
            // lbl_DispoBodega
            // 
            this.lbl_DispoBodega.AutoSize = true;
            this.lbl_DispoBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DispoBodega.Location = new System.Drawing.Point(13, 189);
            this.lbl_DispoBodega.Name = "lbl_DispoBodega";
            this.lbl_DispoBodega.Size = new System.Drawing.Size(110, 20);
            this.lbl_DispoBodega.TabIndex = 14;
            this.lbl_DispoBodega.Text = "bodega actual";
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.Controls.Add(this.lbl_Destino);
            this.pnl_Fondo.Controls.Add(this.lbl_Partida);
            this.pnl_Fondo.Controls.Add(this.dtg_ListaDePasajeros);
            this.pnl_Fondo.Controls.Add(this.lbl_Duracion);
            this.pnl_Fondo.Controls.Add(this.pnl_Aeronave);
            this.pnl_Fondo.Controls.Add(this.btn_Atras);
            this.pnl_Fondo.Controls.Add(this.lbl_Origen);
            this.pnl_Fondo.Controls.Add(this.lbl_TipoDeVuelo);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(960, 605);
            this.pnl_Fondo.TabIndex = 14;
            this.pnl_Fondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseDown);
            this.pnl_Fondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseMove);
            this.pnl_Fondo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseUp);
            // 
            // FrmInformacionDeVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 629);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformacionDeVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformacionDeVuelos";
            this.Load += new System.EventHandler(this.FrmInformacionDeVuelos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmInformacionDeVuelos_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmInformacionDeVuelos_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmInformacionDeVuelos_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaDePasajeros)).EndInit();
            this.pnl_Aeronave.ResumeLayout(false);
            this.pnl_Aeronave.PerformLayout();
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Origen;
        private System.Windows.Forms.Label lbl_Destino;
        private System.Windows.Forms.Label lbl_TipoDeVuelo;
        private System.Windows.Forms.Label lbl_Duracion;
        private System.Windows.Forms.Label lbl_Partida;
        private System.Windows.Forms.DataGridView dtg_ListaDePasajeros;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_Aeronave;
        private System.Windows.Forms.Label lbl_EncabezadoAeronave;
        private System.Windows.Forms.Panel pnl_Aeronave;
        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label lbl_DispoBodega;
        private System.Windows.Forms.Label lbl_Turista;
        private System.Windows.Forms.Label lbl_Premium;
    }
}