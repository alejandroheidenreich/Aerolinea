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
            this.lbl_Disponibilidad = new System.Windows.Forms.Label();
            this.lbl_EncabezadoAeronave = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_CantidadBanios = new System.Windows.Forms.Label();
            this.lbl_CapacidadBodega = new System.Windows.Forms.Label();
            this.pnl_Aeronave = new System.Windows.Forms.Panel();
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
            this.lbl_Duracion.Location = new System.Drawing.Point(794, 71);
            this.lbl_Duracion.Name = "lbl_Duracion";
            this.lbl_Duracion.Size = new System.Drawing.Size(70, 20);
            this.lbl_Duracion.TabIndex = 3;
            this.lbl_Duracion.Text = "duracion";
            // 
            // lbl_Partida
            // 
            this.lbl_Partida.AutoSize = true;
            this.lbl_Partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Partida.Location = new System.Drawing.Point(583, 71);
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
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(15, 12);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(53, 46);
            this.btn_Atras.TabIndex = 7;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_Disponibilidad
            // 
            this.lbl_Disponibilidad.AutoSize = true;
            this.lbl_Disponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Disponibilidad.Location = new System.Drawing.Point(30, 82);
            this.lbl_Disponibilidad.Name = "lbl_Disponibilidad";
            this.lbl_Disponibilidad.Size = new System.Drawing.Size(47, 20);
            this.lbl_Disponibilidad.TabIndex = 8;
            this.lbl_Disponibilidad.Text = "dispo";
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
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Matricula.Location = new System.Drawing.Point(28, 123);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(73, 20);
            this.lbl_Matricula.TabIndex = 10;
            this.lbl_Matricula.Text = "matricula";
            // 
            // lbl_CantidadBanios
            // 
            this.lbl_CantidadBanios.AutoSize = true;
            this.lbl_CantidadBanios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadBanios.Location = new System.Drawing.Point(30, 167);
            this.lbl_CantidadBanios.Name = "lbl_CantidadBanios";
            this.lbl_CantidadBanios.Size = new System.Drawing.Size(53, 20);
            this.lbl_CantidadBanios.TabIndex = 11;
            this.lbl_CantidadBanios.Text = "baños";
            // 
            // lbl_CapacidadBodega
            // 
            this.lbl_CapacidadBodega.AutoSize = true;
            this.lbl_CapacidadBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapacidadBodega.Location = new System.Drawing.Point(28, 203);
            this.lbl_CapacidadBodega.Name = "lbl_CapacidadBodega";
            this.lbl_CapacidadBodega.Size = new System.Drawing.Size(63, 20);
            this.lbl_CapacidadBodega.TabIndex = 12;
            this.lbl_CapacidadBodega.Text = "bodega";
            // 
            // pnl_Aeronave
            // 
            this.pnl_Aeronave.Controls.Add(this.lbl_CapacidadBodega);
            this.pnl_Aeronave.Controls.Add(this.lbl_Disponibilidad);
            this.pnl_Aeronave.Controls.Add(this.lbl_CantidadBanios);
            this.pnl_Aeronave.Controls.Add(this.lbl_EncabezadoAeronave);
            this.pnl_Aeronave.Controls.Add(this.lbl_Matricula);
            this.pnl_Aeronave.Location = new System.Drawing.Point(662, 130);
            this.pnl_Aeronave.Name = "pnl_Aeronave";
            this.pnl_Aeronave.Size = new System.Drawing.Size(272, 323);
            this.pnl_Aeronave.TabIndex = 13;
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
        private System.Windows.Forms.Label lbl_Disponibilidad;
        private System.Windows.Forms.Label lbl_EncabezadoAeronave;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_CantidadBanios;
        private System.Windows.Forms.Label lbl_CapacidadBodega;
        private System.Windows.Forms.Panel pnl_Aeronave;
        private System.Windows.Forms.Panel pnl_Fondo;
    }
}