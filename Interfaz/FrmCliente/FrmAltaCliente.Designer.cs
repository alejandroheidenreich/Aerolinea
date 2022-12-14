namespace Interfaz.FrmCliente
{
    partial class FrmAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCliente));
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.dtp_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_EncabezadoNacimiento = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(310, 407);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 42);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nombre.Location = new System.Drawing.Point(122, 43);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(115, 22);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Apellido.Location = new System.Drawing.Point(122, 96);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(115, 22);
            this.txt_Apellido.TabIndex = 2;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Dni.Location = new System.Drawing.Point(122, 145);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "DNI";
            this.txt_Dni.Size = new System.Drawing.Size(115, 22);
            this.txt_Dni.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(122, 257);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PlaceholderText = "E-Mail";
            this.txt_Email.Size = new System.Drawing.Size(115, 22);
            this.txt_Email.TabIndex = 4;
            // 
            // dtp_Nacimiento
            // 
            this.dtp_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Nacimiento.Location = new System.Drawing.Point(122, 215);
            this.dtp_Nacimiento.Name = "dtp_Nacimiento";
            this.dtp_Nacimiento.Size = new System.Drawing.Size(115, 22);
            this.dtp_Nacimiento.TabIndex = 5;
            // 
            // lbl_EncabezadoNacimiento
            // 
            this.lbl_EncabezadoNacimiento.AutoSize = true;
            this.lbl_EncabezadoNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoNacimiento.Location = new System.Drawing.Point(116, 185);
            this.lbl_EncabezadoNacimiento.Name = "lbl_EncabezadoNacimiento";
            this.lbl_EncabezadoNacimiento.Size = new System.Drawing.Size(135, 16);
            this.lbl_EncabezadoNacimiento.TabIndex = 6;
            this.lbl_EncabezadoNacimiento.Text = "Fecha de Nacimiento";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.Location = new System.Drawing.Point(94, 343);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(190, 62);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_Error.Location = new System.Drawing.Point(64, 292);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(36, 16);
            this.lbl_Error.TabIndex = 8;
            this.lbl_Error.Text = "Error";
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Fondo.Controls.Add(this.lbl_Error);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(357, 448);
            this.pnl_Fondo.TabIndex = 9;
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(381, 472);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_EncabezadoNacimiento);
            this.Controls.Add(this.dtp_Nacimiento);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.DateTimePicker dtp_Nacimiento;
        private System.Windows.Forms.Label lbl_EncabezadoNacimiento;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Panel pnl_Fondo;
    }
}