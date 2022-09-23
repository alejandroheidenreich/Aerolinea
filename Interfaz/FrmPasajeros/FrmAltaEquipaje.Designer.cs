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
            ((System.ComponentModel.ISupportInitialize)(this.nud_PesoEquipaje)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_EquipajeDeMano
            // 
            this.chk_EquipajeDeMano.AutoSize = true;
            this.chk_EquipajeDeMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_EquipajeDeMano.Location = new System.Drawing.Point(73, 55);
            this.chk_EquipajeDeMano.Name = "chk_EquipajeDeMano";
            this.chk_EquipajeDeMano.Size = new System.Drawing.Size(152, 20);
            this.chk_EquipajeDeMano.TabIndex = 0;
            this.chk_EquipajeDeMano.Text = "Equipaje de Mano";
            this.chk_EquipajeDeMano.UseVisualStyleBackColor = true;
            this.chk_EquipajeDeMano.CheckedChanged += new System.EventHandler(this.chk_EquipajeDeMano_CheckedChanged);
            // 
            // btn_AgregarEquipaje
            // 
            this.btn_AgregarEquipaje.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarEquipaje.Image")));
            this.btn_AgregarEquipaje.Location = new System.Drawing.Point(121, 126);
            this.btn_AgregarEquipaje.Name = "btn_AgregarEquipaje";
            this.btn_AgregarEquipaje.Size = new System.Drawing.Size(58, 61);
            this.btn_AgregarEquipaje.TabIndex = 3;
            this.btn_AgregarEquipaje.UseVisualStyleBackColor = true;
            this.btn_AgregarEquipaje.Click += new System.EventHandler(this.btn_AgregarEquipaje_Click);
            // 
            // btn_Cancelar
            // 
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
            this.lbl_KG.Location = new System.Drawing.Point(249, 96);
            this.lbl_KG.Name = "lbl_KG";
            this.lbl_KG.Size = new System.Drawing.Size(29, 17);
            this.lbl_KG.TabIndex = 6;
            this.lbl_KG.Text = "KG.";
            // 
            // nud_PesoEquipaje
            // 
            this.nud_PesoEquipaje.DecimalPlaces = 3;
            this.nud_PesoEquipaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud_PesoEquipaje.Location = new System.Drawing.Point(168, 94);
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
            this.lbl_EncabezadoPeso.Location = new System.Drawing.Point(27, 96);
            this.lbl_EncabezadoPeso.Name = "lbl_EncabezadoPeso";
            this.lbl_EncabezadoPeso.Size = new System.Drawing.Size(135, 16);
            this.lbl_EncabezadoPeso.TabIndex = 8;
            this.lbl_EncabezadoPeso.Text = "Peso del Equipaje";
            // 
            // btn_Confirmar
            // 
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
            this.lbl_Error.Location = new System.Drawing.Point(52, 203);
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
            this.lst_Equipajes.Location = new System.Drawing.Point(331, 25);
            this.lst_Equipajes.Name = "lst_Equipajes";
            this.lst_Equipajes.Size = new System.Drawing.Size(204, 289);
            this.lst_Equipajes.TabIndex = 11;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Eliminar.Location = new System.Drawing.Point(541, 25);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(37, 39);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // FrmAltaEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.lst_Equipajes);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.lbl_EncabezadoPeso);
            this.Controls.Add(this.nud_PesoEquipaje);
            this.Controls.Add(this.lbl_KG);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_AgregarEquipaje);
            this.Controls.Add(this.chk_EquipajeDeMano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaEquipaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaEquipaje";
            this.Load += new System.EventHandler(this.FrmAltaEquipaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PesoEquipaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}