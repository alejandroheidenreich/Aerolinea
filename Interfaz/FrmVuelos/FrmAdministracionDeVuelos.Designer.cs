namespace Interfaz
{
    partial class FrmAdministracionDeVuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministracionDeVuelos));
            this.dtg_Vuelos = new System.Windows.Forms.DataGridView();
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            this.btn_ExaminarVuelo = new System.Windows.Forms.Button();
            this.btn_EliminarVuelo = new System.Windows.Forms.Button();
            this.pic_Lupa = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Vuelos
            // 
            this.dtg_Vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Vuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Vuelos.Location = new System.Drawing.Point(212, 90);
            this.dtg_Vuelos.Name = "dtg_Vuelos";
            this.dtg_Vuelos.RowTemplate.Height = 25;
            this.dtg_Vuelos.Size = new System.Drawing.Size(595, 401);
            this.dtg_Vuelos.TabIndex = 0;
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarVuelo.Image")));
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(69, 153);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(53, 50);
            this.btn_AgregarVuelo.TabIndex = 1;
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            // 
            // btn_ExaminarVuelo
            // 
            this.btn_ExaminarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExaminarVuelo.Image")));
            this.btn_ExaminarVuelo.Location = new System.Drawing.Point(69, 226);
            this.btn_ExaminarVuelo.Name = "btn_ExaminarVuelo";
            this.btn_ExaminarVuelo.Size = new System.Drawing.Size(53, 50);
            this.btn_ExaminarVuelo.TabIndex = 2;
            this.btn_ExaminarVuelo.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarVuelo
            // 
            this.btn_EliminarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_EliminarVuelo.Image")));
            this.btn_EliminarVuelo.Location = new System.Drawing.Point(69, 300);
            this.btn_EliminarVuelo.Name = "btn_EliminarVuelo";
            this.btn_EliminarVuelo.Size = new System.Drawing.Size(53, 50);
            this.btn_EliminarVuelo.TabIndex = 3;
            this.btn_EliminarVuelo.UseVisualStyleBackColor = true;
            // 
            // pic_Lupa
            // 
            this.pic_Lupa.Image = ((System.Drawing.Image)(resources.GetObject("pic_Lupa.Image")));
            this.pic_Lupa.Location = new System.Drawing.Point(212, 52);
            this.pic_Lupa.Name = "pic_Lupa";
            this.pic_Lupa.Size = new System.Drawing.Size(32, 32);
            this.pic_Lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Lupa.TabIndex = 5;
            this.pic_Lupa.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(250, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Buscar";
            this.textBox1.Size = new System.Drawing.Size(557, 26);
            this.textBox1.TabIndex = 7;
            // 
            // FrmAdministracionDeVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pic_Lupa);
            this.Controls.Add(this.btn_EliminarVuelo);
            this.Controls.Add(this.btn_ExaminarVuelo);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.dtg_Vuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministracionDeVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaDeVuelos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Vuelos;
        private System.Windows.Forms.Button btn_AgregarVuelo;
        private System.Windows.Forms.Button btn_ExaminarVuelo;
        private System.Windows.Forms.Button btn_EliminarVuelo;
        private System.Windows.Forms.PictureBox pic_Lupa;
        private System.Windows.Forms.TextBox textBox1;
    }
}