namespace Integrador_II_OrderSys_
{
    partial class Mesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesa));
            this.txtTituloMesa = new System.Windows.Forms.Label();
            this.pnlSelecProductos = new System.Windows.Forms.Panel();
            this.txtOrderSys = new System.Windows.Forms.Label();
            this.picBoxOrderSys = new System.Windows.Forms.PictureBox();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nuDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lstComanda = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.btnSendCocina = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnVerEstado = new System.Windows.Forms.Button();
            this.pnlSelecProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrderSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownCantidad)).BeginInit();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTituloMesa
            // 
            this.txtTituloMesa.AutoSize = true;
            this.txtTituloMesa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTituloMesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTituloMesa.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloMesa.Location = new System.Drawing.Point(602, 40);
            this.txtTituloMesa.Name = "txtTituloMesa";
            this.txtTituloMesa.Size = new System.Drawing.Size(168, 56);
            this.txtTituloMesa.TabIndex = 0;
            this.txtTituloMesa.Text = "Mesa 1";
            this.txtTituloMesa.Click += new System.EventHandler(this.txtTituloMesa_Click);
            // 
            // pnlSelecProductos
            // 
            this.pnlSelecProductos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlSelecProductos.Controls.Add(this.txtOrderSys);
            this.pnlSelecProductos.Controls.Add(this.picBoxOrderSys);
            this.pnlSelecProductos.Controls.Add(this.btnBackMenu);
            this.pnlSelecProductos.Controls.Add(this.btnAgregar);
            this.pnlSelecProductos.Controls.Add(this.txtTituloMesa);
            this.pnlSelecProductos.Controls.Add(this.nuDownCantidad);
            this.pnlSelecProductos.Controls.Add(this.cmbProductos);
            this.pnlSelecProductos.Location = new System.Drawing.Point(-2, -7);
            this.pnlSelecProductos.Name = "pnlSelecProductos";
            this.pnlSelecProductos.Size = new System.Drawing.Size(1282, 321);
            this.pnlSelecProductos.TabIndex = 1;
            this.pnlSelecProductos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSelecProductos_Paint);
            // 
            // txtOrderSys
            // 
            this.txtOrderSys.AutoSize = true;
            this.txtOrderSys.Font = new System.Drawing.Font("Overseer", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderSys.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtOrderSys.Location = new System.Drawing.Point(1008, 222);
            this.txtOrderSys.Name = "txtOrderSys";
            this.txtOrderSys.Size = new System.Drawing.Size(157, 47);
            this.txtOrderSys.TabIndex = 13;
            this.txtOrderSys.Text = "OrderSys\r\n";
            // 
            // picBoxOrderSys
            // 
            this.picBoxOrderSys.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOrderSys.Image")));
            this.picBoxOrderSys.Location = new System.Drawing.Point(992, 40);
            this.picBoxOrderSys.Name = "picBoxOrderSys";
            this.picBoxOrderSys.Size = new System.Drawing.Size(193, 169);
            this.picBoxOrderSys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOrderSys.TabIndex = 12;
            this.picBoxOrderSys.TabStop = false;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.Location = new System.Drawing.Point(26, 40);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(114, 50);
            this.btnBackMenu.TabIndex = 11;
            this.btnBackMenu.Text = "Atrás";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(26, 213);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 73);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nuDownCantidad
            // 
            this.nuDownCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuDownCantidad.Location = new System.Drawing.Point(602, 138);
            this.nuDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDownCantidad.Name = "nuDownCantidad";
            this.nuDownCantidad.Size = new System.Drawing.Size(92, 49);
            this.nuDownCantidad.TabIndex = 3;
            this.nuDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDownCantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cmbProductos
            // 
            this.cmbProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(26, 138);
            this.cmbProductos.MaximumSize = new System.Drawing.Size(500, 0);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(498, 49);
            this.cmbProductos.TabIndex = 2;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstComanda
            // 
            this.lstComanda.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComanda.FormattingEnabled = true;
            this.lstComanda.ItemHeight = 41;
            this.lstComanda.Location = new System.Drawing.Point(17, 19);
            this.lstComanda.Name = "lstComanda";
            this.lstComanda.Size = new System.Drawing.Size(1183, 250);
            this.lstComanda.TabIndex = 2;
            this.lstComanda.SelectedIndexChanged += new System.EventHandler(this.lstComanda_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotal.Location = new System.Drawing.Point(17, 309);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(172, 43);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.Text = "Suma total";
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFondo.Controls.Add(this.btnVerEstado);
            this.pnlFondo.Controls.Add(this.btnSendCocina);
            this.pnlFondo.Controls.Add(this.btnFacturar);
            this.pnlFondo.Controls.Add(this.lstComanda);
            this.pnlFondo.Controls.Add(this.txtTotal);
            this.pnlFondo.Location = new System.Drawing.Point(24, 338);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1229, 408);
            this.pnlFondo.TabIndex = 4;
            // 
            // btnSendCocina
            // 
            this.btnSendCocina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCocina.Location = new System.Drawing.Point(261, 301);
            this.btnSendCocina.Name = "btnSendCocina";
            this.btnSendCocina.Size = new System.Drawing.Size(261, 51);
            this.btnSendCocina.TabIndex = 5;
            this.btnSendCocina.Text = "Enviar a cocina";
            this.btnSendCocina.UseVisualStyleBackColor = true;
            this.btnSendCocina.Click += new System.EventHandler(this.btnSendCocina_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFacturar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(942, 301);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(258, 51);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Generar Factura";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnVerEstado
            // 
            this.btnVerEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstado.Location = new System.Drawing.Point(658, 301);
            this.btnVerEstado.Name = "btnVerEstado";
            this.btnVerEstado.Size = new System.Drawing.Size(192, 51);
            this.btnVerEstado.TabIndex = 6;
            this.btnVerEstado.Text = "Ver estado";
            this.btnVerEstado.UseVisualStyleBackColor = true;
            this.btnVerEstado.Click += new System.EventHandler(this.btnVerEstado_Click);
            // 
            // Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 767);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.pnlSelecProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mesa";
            this.Text = "Mesa";
            this.pnlSelecProductos.ResumeLayout(false);
            this.pnlSelecProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrderSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownCantidad)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTituloMesa;
        private System.Windows.Forms.Panel pnlSelecProductos;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown nuDownCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.ListBox lstComanda;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.PictureBox picBoxOrderSys;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label txtOrderSys;
        private System.Windows.Forms.Button btnSendCocina;
        private System.Windows.Forms.Button btnVerEstado;
    }
}