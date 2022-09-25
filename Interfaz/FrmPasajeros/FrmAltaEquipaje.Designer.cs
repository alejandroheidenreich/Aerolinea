namespace Interfaz.FrmPasajeros
{
    partial class FrmAltaEquipaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaEquipaje));
            this.chk_EquipajeDeMano = new System.Windows.Forms.CheckBox();
            this.btn_AgregarEquipaje = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_KG = new System.Windows.Forms.Label();
            this.nud_PesoEquipaje = new System.Windows.Forms.NumericUpDown();
            this.lbl_EncabezadoPeso = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lst_Equipajes = new System.Windows.Forms.ListBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.lbl_EncabezadoCliente = new System.Windows.Forms.Label();
            this.tt_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PesoEquipaje)).BeginInit();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_EquipajeDeMano
            // 
            this.chk_EquipajeDeMano.AutoSize = true;
            this.chk_EquipajeDeMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_EquipajeDeMano.Location = new System.Drawing.Point(61, 66);
            this.chk_EquipajeDeMano.Name = "chk_EquipajeDeMano";
            this.chk_EquipajeDeMano.Size = new System.Drawing.Size(152, 20);
            this.chk_EquipajeDeMano.TabIndex = 0;
            this.chk_EquipajeDeMano.Text = "Equipaje de Mano";
            this.chk_EquipajeDeMano.UseVisualStyleBackColor = true;
            this.chk_EquipajeDeMano.CheckedChanged += new System.EventHandler(this.chk_EquipajeDeMano_CheckedChanged);
            // 
            // btn_AgregarEquipaje
            // 
            this.btn_AgregarEquipaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarEquipaje.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarEquipaje.Image")));
            this.btn_AgregarEquipaje.Location = new System.Drawing.Point(107, 125);
            this.btn_AgregarEquipaje.Name = "btn_AgregarEquipaje";
            this.btn_AgregarEquipaje.Size = new System.Drawing.Size(58, 61);
            this.btn_AgregarEquipaje.TabIndex = 3;
            this.btn_AgregarEquipaje.UseVisualStyleBackColor = true;
            this.btn_AgregarEquipaje.Click += new System.EventHandler(this.btn_AgregarEquipaje_Click);
            this.btn_AgregarEquipaje.MouseHover += new System.EventHandler(this.btn_AgregarEquipaje_MouseHover);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Location = new System.Drawing.Point(197, 253);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 61);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_KG
            // 
            this.lbl_KG.AutoSize = true;
            this.lbl_KG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KG.Location = new System.Drawing.Point(237, 99);
            this.lbl_KG.Name = "lbl_KG";
            this.lbl_KG.Size = new System.Drawing.Size(29, 17);
            this.lbl_KG.TabIndex = 6;
            this.lbl_KG.Text = "KG.";
            // 
            // nud_PesoEquipaje
            // 
            this.nud_PesoEquipaje.DecimalPlaces = 3;
            this.nud_PesoEquipaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud_PesoEquipaje.Location = new System.Drawing.Point(156, 97);
            this.nud_PesoEquipaje.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_PesoEquipaje.Name = "nud_PesoEquipaje";
            this.nud_PesoEquipaje.Size = new System.Drawing.Size(75, 22);
            this.nud_PesoEquipaje.TabIndex = 7;
            this.nud_PesoEquipaje.ValueChanged += new System.EventHandler(this.nud_PesoEquipaje_ValueChanged);
            // 
            // lbl_EncabezadoPeso
            // 
            this.lbl_EncabezadoPeso.AutoSize = true;
            this.lbl_EncabezadoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPeso.Location = new System.Drawing.Point(15, 99);
            this.lbl_EncabezadoPeso.Name = "lbl_EncabezadoPeso";
            this.lbl_EncabezadoPeso.Size = new System.Drawing.Size(135, 16);
            this.lbl_EncabezadoPeso.TabIndex = 8;
            this.lbl_EncabezadoPeso.Text = "Peso del Equipaje";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirmar.Location = new System.Drawing.Point(26, 253);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(112, 61);
            this.btn_Confirmar.TabIndex = 9;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Error.Location = new System.Drawing.Point(14, 203);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(36, 16);
            this.lbl_Error.TabIndex = 10;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // lst_Equipajes
            // 
            this.lst_Equipajes.FormattingEnabled = true;
            this.lst_Equipajes.ItemHeight = 15;
            this.lst_Equipajes.Location = new System.Drawing.Point(305, 9);
            this.lst_Equipajes.Name = "lst_Equipajes";
            this.lst_Equipajes.Size = new System.Drawing.Size(204, 289);
            this.lst_Equipajes.TabIndex = 11;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Eliminar.Location = new System.Drawing.Point(515, 9);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(37, 38);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoCliente);
            this.pnl_Fondo.Controls.Add(this.lbl_Error);
            this.pnl_Fondo.Controls.Add(this.lbl_KG);
            this.pnl_Fondo.Controls.Add(this.chk_EquipajeDeMano);
            this.pnl_Fondo.Controls.Add(this.nud_PesoEquipaje);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoPeso);
            this.pnl_Fondo.Controls.Add(this.lst_Equipajes);
            this.pnl_Fondo.Controls.Add(this.btn_Eliminar);
            this.pnl_Fondo.Controls.Add(this.btn_AgregarEquipaje);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 16);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(564, 312);
            this.pnl_Fondo.TabIndex = 13;
            this.pnl_Fondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseDown);
            this.pnl_Fondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseMove);
            this.pnl_Fondo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Fondo_MouseUp);
            // 
            // lbl_EncabezadoCliente
            // 
            this.lbl_EncabezadoCliente.AutoSize = true;
            this.lbl_EncabezadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoCliente.Location = new System.Drawing.Point(15, 18);
            this.lbl_EncabezadoCliente.Name = "lbl_EncabezadoCliente";
            this.lbl_EncabezadoCliente.Size = new System.Drawing.Size(57, 18);
            this.lbl_EncabezadoCliente.TabIndex = 13;
            this.lbl_EncabezadoCliente.Text = "cliente";
            // 
            // FrmAltaEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(588, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaEquipaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaEquipaje";
            this.Load += new System.EventHandler(this.FrmAltaEquipaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PesoEquipaje)).EndInit();
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_EquipajeDeMano;
        private System.Windows.Forms.Button btn_AgregarEquipaje;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_KG;
        private System.Windows.Forms.NumericUpDown nud_PesoEquipaje;
        private System.Windows.Forms.Label lbl_EncabezadoPeso;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.ListBox lst_Equipajes;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label lbl_EncabezadoCliente;
        private System.Windows.Forms.ToolTip tt_Ayuda;
    }
}