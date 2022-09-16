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
            this.dtg_Aeronaves = new System.Windows.Forms.DataGridView();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Aeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Aeronaves
            // 
            this.dtg_Aeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Aeronaves.Location = new System.Drawing.Point(49, 21);
            this.dtg_Aeronaves.Name = "dtg_Aeronaves";
            this.dtg_Aeronaves.RowTemplate.Height = 25;
            this.dtg_Aeronaves.Size = new System.Drawing.Size(635, 338);
            this.dtg_Aeronaves.TabIndex = 0;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Seleccionar.Location = new System.Drawing.Point(294, 375);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(158, 51);
            this.btn_Seleccionar.TabIndex = 1;
            this.btn_Seleccionar.Text = "SELECCIONAR";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(664, 387);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(60, 51);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FrmAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.dtg_Aeronaves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAeronaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAeronaves";
            this.Load += new System.EventHandler(this.FrmAeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Aeronaves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Aeronaves;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Salir;
    }
}