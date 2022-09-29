namespace Interfaz.FrmPasajeros
{
    partial class FrmInformacionDelPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacionDelPasajero));
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_PesoAdicional = new System.Windows.Forms.Label();
            this.lbl_EquipajeMano = new System.Windows.Forms.Label();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.lbl_Registro = new System.Windows.Forms.Label();
            this.lbl_EncabezadoPesoAdicional = new System.Windows.Forms.Label();
            this.lbl_EncabezadoEquipajeBodega = new System.Windows.Forms.Label();
            this.lst_EquipajesBodega = new System.Windows.Forms.ListBox();
            this.lbl_EncabezadoEquipajeMano = new System.Windows.Forms.Label();
            this.lbl_EncabezadoClase = new System.Windows.Forms.Label();
            this.lbl_EncabezadoIdRegistro = new System.Windows.Forms.Label();
            this.lbl_EncabezadoCliente = new System.Windows.Forms.Label();
            this.lbl_EncabezadoVuelo = new System.Windows.Forms.Label();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Fondo.Controls.Add(this.btn_Atras);
            this.pnl_Fondo.Controls.Add(this.lbl_PesoAdicional);
            this.pnl_Fondo.Controls.Add(this.lbl_EquipajeMano);
            this.pnl_Fondo.Controls.Add(this.lbl_Clase);
            this.pnl_Fondo.Controls.Add(this.lbl_Registro);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoPesoAdicional);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoEquipajeBodega);
            this.pnl_Fondo.Controls.Add(this.lst_EquipajesBodega);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoEquipajeMano);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoClase);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoIdRegistro);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoCliente);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoVuelo);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(551, 385);
            this.pnl_Fondo.TabIndex = 0;
            // 
            // btn_Atras
            // 
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(15, 15);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(53, 53);
            this.btn_Atras.TabIndex = 0;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_PesoAdicional
            // 
            this.lbl_PesoAdicional.AutoSize = true;
            this.lbl_PesoAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PesoAdicional.Location = new System.Drawing.Point(446, 331);
            this.lbl_PesoAdicional.Name = "lbl_PesoAdicional";
            this.lbl_PesoAdicional.Size = new System.Drawing.Size(44, 20);
            this.lbl_PesoAdicional.TabIndex = 11;
            this.lbl_PesoAdicional.Text = "peso";
            // 
            // lbl_EquipajeMano
            // 
            this.lbl_EquipajeMano.AutoSize = true;
            this.lbl_EquipajeMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EquipajeMano.Location = new System.Drawing.Point(198, 331);
            this.lbl_EquipajeMano.Name = "lbl_EquipajeMano";
            this.lbl_EquipajeMano.Size = new System.Drawing.Size(113, 20);
            this.lbl_EquipajeMano.TabIndex = 10;
            this.lbl_EquipajeMano.Text = "equipaje mano";
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Clase.Location = new System.Drawing.Point(110, 266);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(46, 20);
            this.lbl_Clase.TabIndex = 9;
            this.lbl_Clase.Text = "clase";
            // 
            // lbl_Registro
            // 
            this.lbl_Registro.AutoSize = true;
            this.lbl_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Registro.Location = new System.Drawing.Point(151, 201);
            this.lbl_Registro.Name = "lbl_Registro";
            this.lbl_Registro.Size = new System.Drawing.Size(62, 20);
            this.lbl_Registro.TabIndex = 8;
            this.lbl_Registro.Text = "registro";
            // 
            // lbl_EncabezadoPesoAdicional
            // 
            this.lbl_EncabezadoPesoAdicional.AutoSize = true;
            this.lbl_EncabezadoPesoAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPesoAdicional.Location = new System.Drawing.Point(323, 331);
            this.lbl_EncabezadoPesoAdicional.Name = "lbl_EncabezadoPesoAdicional";
            this.lbl_EncabezadoPesoAdicional.Size = new System.Drawing.Size(117, 20);
            this.lbl_EncabezadoPesoAdicional.TabIndex = 7;
            this.lbl_EncabezadoPesoAdicional.Text = "Peso Adicional:";
            // 
            // lbl_EncabezadoEquipajeBodega
            // 
            this.lbl_EncabezadoEquipajeBodega.AutoSize = true;
            this.lbl_EncabezadoEquipajeBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoEquipajeBodega.Location = new System.Drawing.Point(323, 201);
            this.lbl_EncabezadoEquipajeBodega.Name = "lbl_EncabezadoEquipajeBodega";
            this.lbl_EncabezadoEquipajeBodega.Size = new System.Drawing.Size(157, 20);
            this.lbl_EncabezadoEquipajeBodega.TabIndex = 6;
            this.lbl_EncabezadoEquipajeBodega.Text = "Equipaje de Bodega:";
            // 
            // lst_EquipajesBodega
            // 
            this.lst_EquipajesBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_EquipajesBodega.FormattingEnabled = true;
            this.lst_EquipajesBodega.ItemHeight = 20;
            this.lst_EquipajesBodega.Location = new System.Drawing.Point(323, 224);
            this.lst_EquipajesBodega.Name = "lst_EquipajesBodega";
            this.lst_EquipajesBodega.Size = new System.Drawing.Size(200, 104);
            this.lst_EquipajesBodega.TabIndex = 5;
            // 
            // lbl_EncabezadoEquipajeMano
            // 
            this.lbl_EncabezadoEquipajeMano.AutoSize = true;
            this.lbl_EncabezadoEquipajeMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoEquipajeMano.Location = new System.Drawing.Point(51, 331);
            this.lbl_EncabezadoEquipajeMano.Name = "lbl_EncabezadoEquipajeMano";
            this.lbl_EncabezadoEquipajeMano.Size = new System.Drawing.Size(141, 20);
            this.lbl_EncabezadoEquipajeMano.TabIndex = 4;
            this.lbl_EncabezadoEquipajeMano.Text = "Equipaje de Mano:";
            // 
            // lbl_EncabezadoClase
            // 
            this.lbl_EncabezadoClase.AutoSize = true;
            this.lbl_EncabezadoClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoClase.Location = new System.Drawing.Point(51, 266);
            this.lbl_EncabezadoClase.Name = "lbl_EncabezadoClase";
            this.lbl_EncabezadoClase.Size = new System.Drawing.Size(53, 20);
            this.lbl_EncabezadoClase.TabIndex = 3;
            this.lbl_EncabezadoClase.Text = "Clase:";
            // 
            // lbl_EncabezadoIdRegistro
            // 
            this.lbl_EncabezadoIdRegistro.AutoSize = true;
            this.lbl_EncabezadoIdRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoIdRegistro.Location = new System.Drawing.Point(51, 201);
            this.lbl_EncabezadoIdRegistro.Name = "lbl_EncabezadoIdRegistro";
            this.lbl_EncabezadoIdRegistro.Size = new System.Drawing.Size(94, 20);
            this.lbl_EncabezadoIdRegistro.TabIndex = 2;
            this.lbl_EncabezadoIdRegistro.Text = "ID Registro:";
            // 
            // lbl_EncabezadoCliente
            // 
            this.lbl_EncabezadoCliente.AutoSize = true;
            this.lbl_EncabezadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoCliente.Location = new System.Drawing.Point(110, 30);
            this.lbl_EncabezadoCliente.Name = "lbl_EncabezadoCliente";
            this.lbl_EncabezadoCliente.Size = new System.Drawing.Size(62, 20);
            this.lbl_EncabezadoCliente.TabIndex = 1;
            this.lbl_EncabezadoCliente.Text = "cliente";
            // 
            // lbl_EncabezadoVuelo
            // 
            this.lbl_EncabezadoVuelo.AutoSize = true;
            this.lbl_EncabezadoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoVuelo.Location = new System.Drawing.Point(17, 108);
            this.lbl_EncabezadoVuelo.Name = "lbl_EncabezadoVuelo";
            this.lbl_EncabezadoVuelo.Size = new System.Drawing.Size(51, 20);
            this.lbl_EncabezadoVuelo.TabIndex = 0;
            this.lbl_EncabezadoVuelo.Text = "vuelo";
            // 
            // FrmInformacionDelPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(575, 409);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformacionDelPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformacionDelPasajero";
            this.Load += new System.EventHandler(this.FrmInformacionDelPasajero_Load);
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label lbl_EncabezadoVuelo;
        private System.Windows.Forms.Label lbl_EncabezadoCliente;
        private System.Windows.Forms.Label lbl_EncabezadoIdRegistro;
        private System.Windows.Forms.Label lbl_PesoAdicional;
        private System.Windows.Forms.Label lbl_EquipajeMano;
        private System.Windows.Forms.Label lbl_Clase;
        private System.Windows.Forms.Label lbl_Registro;
        private System.Windows.Forms.Label lbl_EncabezadoPesoAdicional;
        private System.Windows.Forms.Label lbl_EncabezadoEquipajeBodega;
        private System.Windows.Forms.ListBox lst_EquipajesBodega;
        private System.Windows.Forms.Label lbl_EncabezadoEquipajeMano;
        private System.Windows.Forms.Label lbl_EncabezadoClase;
        private System.Windows.Forms.Button btn_Atras;
    }
}