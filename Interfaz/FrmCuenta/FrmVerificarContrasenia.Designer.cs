namespace Interfaz.FrmCuenta
{
    partial class FrmVerificarContrasenia
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
            this.lbl_IngreseContrasenia = new System.Windows.Forms.Label();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pnl_FondoPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_IngreseContrasenia
            // 
            this.lbl_IngreseContrasenia.AutoSize = true;
            this.lbl_IngreseContrasenia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_IngreseContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_IngreseContrasenia.Location = new System.Drawing.Point(66, 63);
            this.lbl_IngreseContrasenia.Name = "lbl_IngreseContrasenia";
            this.lbl_IngreseContrasenia.Size = new System.Drawing.Size(171, 24);
            this.lbl_IngreseContrasenia.TabIndex = 0;
            this.lbl_IngreseContrasenia.Text = "Ingrese contraseña";
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Contrasenia.Location = new System.Drawing.Point(66, 110);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.PasswordChar = '⚫';
            this.txt_Contrasenia.Size = new System.Drawing.Size(171, 29);
            this.txt_Contrasenia.TabIndex = 1;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.Location = new System.Drawing.Point(75, 179);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(149, 39);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(224, 251);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(50, 44);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // pnl_FondoPrincipal
            // 
            this.pnl_FondoPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_FondoPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnl_FondoPrincipal.Name = "pnl_FondoPrincipal";
            this.pnl_FondoPrincipal.Size = new System.Drawing.Size(280, 300);
            this.pnl_FondoPrincipal.TabIndex = 4;
            this.pnl_FondoPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_FondoPrincipal_MouseDown);
            this.pnl_FondoPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_FondoPrincipal_MouseMove);
            this.pnl_FondoPrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_FondoPrincipal_MouseUp);
            // 
            // FrmVerificarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(304, 324);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.lbl_IngreseContrasenia);
            this.Controls.Add(this.pnl_FondoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerificarContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerificarContrasenia";
            this.Load += new System.EventHandler(this.FrmVerificarContrasenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IngreseContrasenia;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel pnl_FondoPrincipal;
    }
}