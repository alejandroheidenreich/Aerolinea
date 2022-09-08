namespace Interfaz
{
    partial class VentaDeVuelos
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
            this.cb_MenuDelDia = new System.Windows.Forms.CheckBox();
            this.cb_Wiifi = new System.Windows.Forms.CheckBox();
            this.cb_Disponibilidad = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_MenuDelDia
            // 
            this.cb_MenuDelDia.AutoSize = true;
            this.cb_MenuDelDia.Location = new System.Drawing.Point(35, 25);
            this.cb_MenuDelDia.Name = "cb_MenuDelDia";
            this.cb_MenuDelDia.Size = new System.Drawing.Size(96, 19);
            this.cb_MenuDelDia.TabIndex = 0;
            this.cb_MenuDelDia.Text = "Menu del Dia";
            this.cb_MenuDelDia.UseVisualStyleBackColor = true;
            // 
            // cb_Wiifi
            // 
            this.cb_Wiifi.AutoSize = true;
            this.cb_Wiifi.Location = new System.Drawing.Point(35, 50);
            this.cb_Wiifi.Name = "cb_Wiifi";
            this.cb_Wiifi.Size = new System.Drawing.Size(50, 19);
            this.cb_Wiifi.TabIndex = 1;
            this.cb_Wiifi.Text = "Wiifi";
            this.cb_Wiifi.UseVisualStyleBackColor = true;
            // 
            // cb_Disponibilidad
            // 
            this.cb_Disponibilidad.AutoSize = true;
            this.cb_Disponibilidad.Location = new System.Drawing.Point(35, 75);
            this.cb_Disponibilidad.Name = "cb_Disponibilidad";
            this.cb_Disponibilidad.Size = new System.Drawing.Size(102, 19);
            this.cb_Disponibilidad.TabIndex = 2;
            this.cb_Disponibilidad.Text = "Disponibilidad";
            this.cb_Disponibilidad.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(675, 414);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_Vender
            // 
            this.btn_Vender.Location = new System.Drawing.Point(12, 248);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(127, 57);
            this.btn_Vender.TabIndex = 4;
            this.btn_Vender.Text = "Vender Pasaje";
            this.btn_Vender.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(12, 339);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(127, 57);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 208);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(5, 211);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(112, 15);
            this.lbl_cantidad.TabIndex = 7;
            this.lbl_cantidad.Text = "Cantidad de Pasajes";
            // 
            // VentaDeVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 502);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_Disponibilidad);
            this.Controls.Add(this.cb_Wiifi);
            this.Controls.Add(this.cb_MenuDelDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentaDeVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentaDeVuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_MenuDelDia;
        private System.Windows.Forms.CheckBox cb_Wiifi;
        private System.Windows.Forms.CheckBox cb_Disponibilidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_cantidad;
    }
}