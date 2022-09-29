namespace Interfaz
{
    partial class FrmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pnl_Divisor = new System.Windows.Forms.Panel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_linea1 = new System.Windows.Forms.Label();
            this.lbl_linea2 = new System.Windows.Forms.Label();
            this.lbl_recuperarContrasenia = new System.Windows.Forms.LinkLabel();
            this.lbl_mensajeDeError = new System.Windows.Forms.Label();
            this.btn_BotonAutoCompletado = new System.Windows.Forms.Button();
            this.pnl_Divisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_usuario.Location = new System.Drawing.Point(312, 66);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "USUARIO";
            this.txt_usuario.Size = new System.Drawing.Size(352, 17);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contrasenia.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_contrasenia.Location = new System.Drawing.Point(312, 136);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.PasswordChar = '⚫';
            this.txt_contrasenia.PlaceholderText = "CONTRASEÑA";
            this.txt_contrasenia.Size = new System.Drawing.Size(352, 17);
            this.txt_contrasenia.TabIndex = 2;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Ingresar.FlatAppearance.BorderSize = 0;
            this.btn_Ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Ingresar.Location = new System.Drawing.Point(312, 216);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(358, 40);
            this.btn_Ingresar.TabIndex = 0;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(709, 259);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 38);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pnl_Divisor
            // 
            this.pnl_Divisor.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Divisor.Controls.Add(this.pic_Logo);
            this.pnl_Divisor.Location = new System.Drawing.Point(0, 0);
            this.pnl_Divisor.Name = "pnl_Divisor";
            this.pnl_Divisor.Size = new System.Drawing.Size(250, 330);
            this.pnl_Divisor.TabIndex = 5;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.SteelBlue;
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(250, 330);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            this.pic_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Logo_MouseDown);
            this.pic_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_Logo_MouseMove);
            this.pic_Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Logo_MouseUp);
            // 
            // lbl_linea1
            // 
            this.lbl_linea1.AutoSize = true;
            this.lbl_linea1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_linea1.Location = new System.Drawing.Point(312, 88);
            this.lbl_linea1.Name = "lbl_linea1";
            this.lbl_linea1.Size = new System.Drawing.Size(352, 15);
            this.lbl_linea1.TabIndex = 6;
            this.lbl_linea1.Text = "_____________________________________________________________________";
            // 
            // lbl_linea2
            // 
            this.lbl_linea2.AutoSize = true;
            this.lbl_linea2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_linea2.Location = new System.Drawing.Point(312, 158);
            this.lbl_linea2.Name = "lbl_linea2";
            this.lbl_linea2.Size = new System.Drawing.Size(352, 15);
            this.lbl_linea2.TabIndex = 7;
            this.lbl_linea2.Text = "_____________________________________________________________________";
            // 
            // lbl_recuperarContrasenia
            // 
            this.lbl_recuperarContrasenia.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lbl_recuperarContrasenia.AutoSize = true;
            this.lbl_recuperarContrasenia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_recuperarContrasenia.LinkColor = System.Drawing.Color.DimGray;
            this.lbl_recuperarContrasenia.Location = new System.Drawing.Point(422, 271);
            this.lbl_recuperarContrasenia.Name = "lbl_recuperarContrasenia";
            this.lbl_recuperarContrasenia.Size = new System.Drawing.Size(141, 16);
            this.lbl_recuperarContrasenia.TabIndex = 5;
            this.lbl_recuperarContrasenia.TabStop = true;
            this.lbl_recuperarContrasenia.Text = "¿Olvidaste tu contraseña?";
            this.lbl_recuperarContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_recuperarContrasenia_LinkClicked);
            // 
            // lbl_mensajeDeError
            // 
            this.lbl_mensajeDeError.AutoSize = true;
            this.lbl_mensajeDeError.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_mensajeDeError.Image = ((System.Drawing.Image)(resources.GetObject("lbl_mensajeDeError.Image")));
            this.lbl_mensajeDeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensajeDeError.Location = new System.Drawing.Point(312, 186);
            this.lbl_mensajeDeError.Name = "lbl_mensajeDeError";
            this.lbl_mensajeDeError.Size = new System.Drawing.Size(129, 16);
            this.lbl_mensajeDeError.TabIndex = 1;
            this.lbl_mensajeDeError.Text = "     Mensaje de Error";
            this.lbl_mensajeDeError.Visible = false;
            // 
            // btn_BotonAutoCompletado
            // 
            this.btn_BotonAutoCompletado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_BotonAutoCompletado.FlatAppearance.BorderSize = 0;
            this.btn_BotonAutoCompletado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_BotonAutoCompletado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BotonAutoCompletado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BotonAutoCompletado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BotonAutoCompletado.ForeColor = System.Drawing.Color.LightGray;
            this.btn_BotonAutoCompletado.Location = new System.Drawing.Point(738, 12);
            this.btn_BotonAutoCompletado.Name = "btn_BotonAutoCompletado";
            this.btn_BotonAutoCompletado.Size = new System.Drawing.Size(30, 29);
            this.btn_BotonAutoCompletado.TabIndex = 3;
            this.btn_BotonAutoCompletado.Text = "©";
            this.btn_BotonAutoCompletado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_BotonAutoCompletado.UseVisualStyleBackColor = false;
            this.btn_BotonAutoCompletado.Click += new System.EventHandler(this.btn_BotonAutoCompletado_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btn_BotonAutoCompletado);
            this.Controls.Add(this.lbl_mensajeDeError);
            this.Controls.Add(this.lbl_recuperarContrasenia);
            this.Controls.Add(this.lbl_linea2);
            this.Controls.Add(this.lbl_linea1);
            this.Controls.Add(this.pnl_Divisor);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogIn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseUp);
            this.pnl_Divisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel pnl_Divisor;
        private System.Windows.Forms.Label lbl_linea1;
        private System.Windows.Forms.Label lbl_linea2;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.LinkLabel lbl_recuperarContrasenia;
        private System.Windows.Forms.Label lbl_mensajeDeError;
        private System.Windows.Forms.Button btn_BotonAutoCompletado;
    }
}
