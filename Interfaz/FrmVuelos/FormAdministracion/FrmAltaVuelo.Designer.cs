namespace Interfaz.FrmVuelos.FormAdministracion
{
    partial class FrmAltaVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaVuelo));
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.cmb_Aeronave = new System.Windows.Forms.ComboBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_MasInfoAeronave = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.lbl_Aeronave = new System.Windows.Forms.Label();
            this.lbl_MensajeError = new System.Windows.Forms.Label();
            this.dtp_Partida = new System.Windows.Forms.DateTimePicker();
            this.lbl_Partida = new System.Windows.Forms.Label();
            this.pnl_FondoPrincipal = new System.Windows.Forms.Panel();
            this.chk_Alcohol = new System.Windows.Forms.CheckBox();
            this.chk_SinAlcohol = new System.Windows.Forms.CheckBox();
            this.chk_Premium = new System.Windows.Forms.CheckBox();
            this.chk_Vegano = new System.Windows.Forms.CheckBox();
            this.chk_Comida = new System.Windows.Forms.CheckBox();
            this.chk_Wifi = new System.Windows.Forms.CheckBox();
            this.tt_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_FondoPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(40, 50);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(179, 28);
            this.cmb_Origen.TabIndex = 0;
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(40, 104);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(179, 28);
            this.cmb_Destino.TabIndex = 1;
            // 
            // cmb_Aeronave
            // 
            this.cmb_Aeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Aeronave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Aeronave.FormattingEnabled = true;
            this.cmb_Aeronave.Location = new System.Drawing.Point(40, 158);
            this.cmb_Aeronave.Name = "cmb_Aeronave";
            this.cmb_Aeronave.Size = new System.Drawing.Size(131, 28);
            this.cmb_Aeronave.TabIndex = 2;
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(440, 279);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 41);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_MasInfoAeronave
            // 
            this.btn_MasInfoAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MasInfoAeronave.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MasInfoAeronave.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_MasInfoAeronave.Location = new System.Drawing.Point(177, 158);
            this.btn_MasInfoAeronave.Name = "btn_MasInfoAeronave";
            this.btn_MasInfoAeronave.Size = new System.Drawing.Size(42, 32);
            this.btn_MasInfoAeronave.TabIndex = 3;
            this.btn_MasInfoAeronave.Text = "?";
            this.btn_MasInfoAeronave.UseVisualStyleBackColor = true;
            this.btn_MasInfoAeronave.Click += new System.EventHandler(this.btn_MasInfoAeronave_Click);
            this.btn_MasInfoAeronave.MouseHover += new System.EventHandler(this.btn_MasInfoAeronave_MouseHover);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(80, 250);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(361, 39);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_Origen.Location = new System.Drawing.Point(40, 27);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(77, 20);
            this.lbl_Origen.TabIndex = 6;
            this.lbl_Origen.Text = "ORIGEN:";
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_Destino.Location = new System.Drawing.Point(40, 81);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(84, 20);
            this.lbl_Destino.TabIndex = 7;
            this.lbl_Destino.Text = "DESTINO:";
            // 
            // lbl_Aeronave
            // 
            this.lbl_Aeronave.AutoSize = true;
            this.lbl_Aeronave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_Aeronave.Location = new System.Drawing.Point(40, 135);
            this.lbl_Aeronave.Name = "lbl_Aeronave";
            this.lbl_Aeronave.Size = new System.Drawing.Size(103, 20);
            this.lbl_Aeronave.TabIndex = 8;
            this.lbl_Aeronave.Text = "AERONAVE:";
            // 
            // lbl_MensajeError
            // 
            this.lbl_MensajeError.AutoSize = true;
            this.lbl_MensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MensajeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_MensajeError.Image = ((System.Drawing.Image)(resources.GetObject("lbl_MensajeError.Image")));
            this.lbl_MensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MensajeError.Location = new System.Drawing.Point(18, 292);
            this.lbl_MensajeError.Name = "lbl_MensajeError";
            this.lbl_MensajeError.Size = new System.Drawing.Size(72, 15);
            this.lbl_MensajeError.TabIndex = 11;
            this.lbl_MensajeError.Text = "       ERROR";
            // 
            // dtp_Partida
            // 
            this.dtp_Partida.CustomFormat = "HH:mm - dd/MM/yyyy";
            this.dtp_Partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_Partida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Partida.Location = new System.Drawing.Point(271, 52);
            this.dtp_Partida.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtp_Partida.Name = "dtp_Partida";
            this.dtp_Partida.Size = new System.Drawing.Size(194, 26);
            this.dtp_Partida.TabIndex = 4;
            this.dtp_Partida.ValueChanged += new System.EventHandler(this.dtp_Partida_ValueChanged);
            // 
            // lbl_Partida
            // 
            this.lbl_Partida.AutoSize = true;
            this.lbl_Partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_Partida.Location = new System.Drawing.Point(271, 27);
            this.lbl_Partida.Name = "lbl_Partida";
            this.lbl_Partida.Size = new System.Drawing.Size(83, 20);
            this.lbl_Partida.TabIndex = 14;
            this.lbl_Partida.Text = "PARTIDA:";
            // 
            // pnl_FondoPrincipal
            // 
            this.pnl_FondoPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_FondoPrincipal.Controls.Add(this.chk_Alcohol);
            this.pnl_FondoPrincipal.Controls.Add(this.chk_SinAlcohol);
            this.pnl_FondoPrincipal.Controls.Add(this.lbl_MensajeError);
            this.pnl_FondoPrincipal.Controls.Add(this.chk_Premium);
            this.pnl_FondoPrincipal.Controls.Add(this.chk_Vegano);
            this.pnl_FondoPrincipal.Controls.Add(this.chk_Comida);
            this.pnl_FondoPrincipal.Controls.Add(this.chk_Wifi);
            this.pnl_FondoPrincipal.Controls.Add(this.btn_Salir);
            this.pnl_FondoPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnl_FondoPrincipal.Name = "pnl_FondoPrincipal";
            this.pnl_FondoPrincipal.Size = new System.Drawing.Size(491, 323);
            this.pnl_FondoPrincipal.TabIndex = 15;
            this.pnl_FondoPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_FondoPrincipal_MouseDown);
            this.pnl_FondoPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_FondoPrincipal_MouseMove);
            this.pnl_FondoPrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_FondoPrincipal_MouseUp);
            // 
            // chk_Alcohol
            // 
            this.chk_Alcohol.AutoSize = true;
            this.chk_Alcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_Alcohol.Location = new System.Drawing.Point(259, 204);
            this.chk_Alcohol.Name = "chk_Alcohol";
            this.chk_Alcohol.Size = new System.Drawing.Size(170, 24);
            this.chk_Alcohol.TabIndex = 10;
            this.chk_Alcohol.Text = "Bebidas Alcoholicas";
            this.chk_Alcohol.UseVisualStyleBackColor = true;
            // 
            // chk_SinAlcohol
            // 
            this.chk_SinAlcohol.AutoSize = true;
            this.chk_SinAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_SinAlcohol.Location = new System.Drawing.Point(259, 165);
            this.chk_SinAlcohol.Name = "chk_SinAlcohol";
            this.chk_SinAlcohol.Size = new System.Drawing.Size(169, 24);
            this.chk_SinAlcohol.TabIndex = 9;
            this.chk_SinAlcohol.Text = "Bebidas Sin Alcohol";
            this.chk_SinAlcohol.UseVisualStyleBackColor = true;
            // 
            // chk_Premium
            // 
            this.chk_Premium.AutoSize = true;
            this.chk_Premium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_Premium.Location = new System.Drawing.Point(351, 135);
            this.chk_Premium.Name = "chk_Premium";
            this.chk_Premium.Size = new System.Drawing.Size(134, 24);
            this.chk_Premium.TabIndex = 8;
            this.chk_Premium.Text = "Menu Premium";
            this.chk_Premium.UseVisualStyleBackColor = true;
            this.chk_Premium.Visible = false;
            // 
            // chk_Vegano
            // 
            this.chk_Vegano.AutoSize = true;
            this.chk_Vegano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_Vegano.Location = new System.Drawing.Point(351, 106);
            this.chk_Vegano.Name = "chk_Vegano";
            this.chk_Vegano.Size = new System.Drawing.Size(128, 24);
            this.chk_Vegano.TabIndex = 7;
            this.chk_Vegano.Text = "Menu Vegano";
            this.chk_Vegano.UseVisualStyleBackColor = true;
            this.chk_Vegano.Visible = false;
            // 
            // chk_Comida
            // 
            this.chk_Comida.AutoSize = true;
            this.chk_Comida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_Comida.Location = new System.Drawing.Point(259, 119);
            this.chk_Comida.Name = "chk_Comida";
            this.chk_Comida.Size = new System.Drawing.Size(82, 24);
            this.chk_Comida.TabIndex = 6;
            this.chk_Comida.Text = "Comida";
            this.chk_Comida.UseVisualStyleBackColor = true;
            this.chk_Comida.CheckedChanged += new System.EventHandler(this.chk_Comida_CheckedChanged);
            // 
            // chk_Wifi
            // 
            this.chk_Wifi.AutoSize = true;
            this.chk_Wifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_Wifi.Location = new System.Drawing.Point(259, 80);
            this.chk_Wifi.Name = "chk_Wifi";
            this.chk_Wifi.Size = new System.Drawing.Size(68, 24);
            this.chk_Wifi.TabIndex = 5;
            this.chk_Wifi.Text = "WIFII";
            this.chk_Wifi.UseVisualStyleBackColor = true;
            // 
            // FrmAltaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(515, 347);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Partida);
            this.Controls.Add(this.dtp_Partida);
            this.Controls.Add(this.lbl_Aeronave);
            this.Controls.Add(this.lbl_Destino);
            this.Controls.Add(this.lbl_Origen);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_MasInfoAeronave);
            this.Controls.Add(this.cmb_Aeronave);
            this.Controls.Add(this.cmb_Destino);
            this.Controls.Add(this.cmb_Origen);
            this.Controls.Add(this.pnl_FondoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaVuelo";
            this.Load += new System.EventHandler(this.FrmAltaVuelo_Load);
            this.pnl_FondoPrincipal.ResumeLayout(false);
            this.pnl_FondoPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Origen;
        private System.Windows.Forms.ComboBox cmb_Destino;
        private System.Windows.Forms.ComboBox cmb_Aeronave;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_MasInfoAeronave;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Origen;
        private System.Windows.Forms.Label lbl_Destino;
        private System.Windows.Forms.Label lbl_Aeronave;
        private System.Windows.Forms.Label lbl_MensajeError;
        private System.Windows.Forms.DateTimePicker dtp_Partida;
        private System.Windows.Forms.Label lbl_Partida;
        private System.Windows.Forms.Panel pnl_FondoPrincipal;
        private System.Windows.Forms.ToolTip tt_Ayuda;
        private System.Windows.Forms.CheckBox chk_Alcohol;
        private System.Windows.Forms.CheckBox chk_SinAlcohol;
        private System.Windows.Forms.CheckBox chk_Premium;
        private System.Windows.Forms.CheckBox chk_Vegano;
        private System.Windows.Forms.CheckBox chk_Comida;
        private System.Windows.Forms.CheckBox chk_Wifi;
    }
}