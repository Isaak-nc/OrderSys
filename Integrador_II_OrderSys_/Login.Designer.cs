namespace Integrador_II_OrderSys_
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Integrador_II_OrderSys_.Properties.Resources.Group;
            this.pictureBox1.Location = new System.Drawing.Point(237, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(498, 322);
            this.txtBoxUsuario.MaximumSize = new System.Drawing.Size(500, 500);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(250, 35);
            this.txtBoxUsuario.TabIndex = 1;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Location = new System.Drawing.Point(498, 423);
            this.txtBoxContraseña.MaximumSize = new System.Drawing.Size(500, 500);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.Size = new System.Drawing.Size(250, 35);
            this.txtBoxContraseña.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(175, 316);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(273, 41);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Ingrese su usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(126, 417);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(322, 41);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Text = "Ingrese su contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(385, 516);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 61);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Acceder";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 670);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.Button btnLogin;
    }
}

