namespace Interfaz.FrmCliente
{
    partial class FrmEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCliente));
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_EditarCliente = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.dtp_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_EncabezadoNacimiento = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Fondo.Controls.Add(this.btn_Salir);
            this.pnl_Fondo.Controls.Add(this.btn_EditarCliente);
            this.pnl_Fondo.Controls.Add(this.lbl_Error);
            this.pnl_Fondo.Controls.Add(this.txt_Email);
            this.pnl_Fondo.Controls.Add(this.dtp_Nacimiento);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoNacimiento);
            this.pnl_Fondo.Controls.Add(this.txt_Dni);
            this.pnl_Fondo.Controls.Add(this.txt_Apellido);
            this.pnl_Fondo.Controls.Add(this.txt_Nombre);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(357, 448);
            this.pnl_Fondo.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(296, 394);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 42);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_EditarCliente
            // 
            this.btn_EditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditarCliente.Image")));
            this.btn_EditarCliente.Location = new System.Drawing.Point(80, 330);
            this.btn_EditarCliente.Name = "btn_EditarCliente";
            this.btn_EditarCliente.Size = new System.Drawing.Size(190, 62);
            this.btn_EditarCliente.TabIndex = 7;
            this.btn_EditarCliente.UseVisualStyleBackColor = true;
            this.btn_EditarCliente.Click += new System.EventHandler(this.btn_EditarCliente_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_Error.Location = new System.Drawing.Point(65, 293);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(36, 16);
            this.lbl_Error.TabIndex = 6;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(110, 246);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PlaceholderText = "E-Mail";
            this.txt_Email.Size = new System.Drawing.Size(115, 22);
            this.txt_Email.TabIndex = 5;
            // 
            // dtp_Nacimiento
            // 
            this.dtp_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Nacimiento.Location = new System.Drawing.Point(110, 203);
            this.dtp_Nacimiento.MaxDate = new System.DateTime(2022, 9, 25, 0, 0, 0, 0);
            this.dtp_Nacimiento.Name = "dtp_Nacimiento";
            this.dtp_Nacimiento.Size = new System.Drawing.Size(115, 22);
            this.dtp_Nacimiento.TabIndex = 4;
            this.dtp_Nacimiento.Value = new System.DateTime(2022, 9, 25, 0, 0, 0, 0);
            // 
            // lbl_EncabezadoNacimiento
            // 
            this.lbl_EncabezadoNacimiento.AutoSize = true;
            this.lbl_EncabezadoNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoNacimiento.Location = new System.Drawing.Point(105, 173);
            this.lbl_EncabezadoNacimiento.Name = "lbl_EncabezadoNacimiento";
            this.lbl_EncabezadoNacimiento.Size = new System.Drawing.Size(135, 16);
            this.lbl_EncabezadoNacimiento.TabIndex = 3;
            this.lbl_EncabezadoNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Dni.Location = new System.Drawing.Point(110, 133);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "DNI";
            this.txt_Dni.ReadOnly = true;
            this.txt_Dni.Size = new System.Drawing.Size(115, 22);
            this.txt_Dni.TabIndex = 2;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Apellido.Location = new System.Drawing.Point(110, 84);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(115, 22);
            this.txt_Apellido.TabIndex = 1;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nombre.Location = new System.Drawing.Point(110, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(115, 22);
            this.txt_Nombre.TabIndex = 0;
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(381, 472);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarCliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.Label lbl_EncabezadoNacimiento;
        private System.Windows.Forms.DateTimePicker dtp_Nacimiento;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_EditarCliente;
        private System.Windows.Forms.Button btn_Salir;
    }
}