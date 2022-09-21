﻿namespace Interfaz.FrmVuelos.FormAdministracion
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Aeronaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Aeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Aeronaves.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Aeronaves.Location = new System.Drawing.Point(16, 22);
            this.dtg_Aeronaves.MultiSelect = false;
            this.dtg_Aeronaves.Name = "dtg_Aeronaves";
            this.dtg_Aeronaves.ReadOnly = true;
            this.dtg_Aeronaves.RowHeadersVisible = false;
            this.dtg_Aeronaves.RowTemplate.Height = 25;
            this.dtg_Aeronaves.Size = new System.Drawing.Size(682, 313);
            this.dtg_Aeronaves.TabIndex = 0;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Seleccionar.Location = new System.Drawing.Point(224, 352);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(299, 51);
            this.btn_Seleccionar.TabIndex = 1;
            this.btn_Seleccionar.Text = "SELECCIONAR";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(671, 376);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 47);
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
            this.pnl_Fondo.Size = new System.Drawing.Size(722, 426);
            this.pnl_Fondo.TabIndex = 3;
            // 
            // FrmAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(746, 450);
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