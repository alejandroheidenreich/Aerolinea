namespace Interfaz
{
    partial class ListaDeVuelos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            this.btn_ExaminarVuelo = new System.Windows.Forms.Button();
            this.btn_EliminarVuelo = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(707, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(51, 20);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(132, 59);
            this.btn_AgregarVuelo.TabIndex = 1;
            this.btn_AgregarVuelo.Text = "Agregar Nuevo Vuelo";
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            // 
            // btn_ExaminarVuelo
            // 
            this.btn_ExaminarVuelo.Location = new System.Drawing.Point(210, 20);
            this.btn_ExaminarVuelo.Name = "btn_ExaminarVuelo";
            this.btn_ExaminarVuelo.Size = new System.Drawing.Size(132, 59);
            this.btn_ExaminarVuelo.TabIndex = 2;
            this.btn_ExaminarVuelo.Text = "Examinar Vuelo";
            this.btn_ExaminarVuelo.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarVuelo
            // 
            this.btn_EliminarVuelo.Location = new System.Drawing.Point(370, 20);
            this.btn_EliminarVuelo.Name = "btn_EliminarVuelo";
            this.btn_EliminarVuelo.Size = new System.Drawing.Size(132, 59);
            this.btn_EliminarVuelo.TabIndex = 3;
            this.btn_EliminarVuelo.Text = "Eliminar Vuelo";
            this.btn_EliminarVuelo.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(733, 20);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(132, 59);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // ListaDeVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_EliminarVuelo);
            this.Controls.Add(this.btn_ExaminarVuelo);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaDeVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDeVuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AgregarVuelo;
        private System.Windows.Forms.Button btn_ExaminarVuelo;
        private System.Windows.Forms.Button btn_EliminarVuelo;
        private System.Windows.Forms.Button btn_Salir;
    }
}