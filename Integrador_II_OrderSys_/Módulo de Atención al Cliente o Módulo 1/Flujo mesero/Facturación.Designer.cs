namespace Integrador_II_OrderSys_.Flujo_mesero
{
    partial class Facturación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturación));
            this.lvFactura = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFactura = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtEstadoFactura = new System.Windows.Forms.Label();
            this.cmbFormatoPago = new System.Windows.Forms.ComboBox();
            this.txtPago = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtCodigoFactura = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFactura
            // 
            this.lvFactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFactura.FullRowSelect = true;
            this.lvFactura.HideSelection = false;
            this.lvFactura.Location = new System.Drawing.Point(44, 387);
            this.lvFactura.Name = "lvFactura";
            this.lvFactura.Size = new System.Drawing.Size(1010, 320);
            this.lvFactura.TabIndex = 0;
            this.lvFactura.UseCompatibleStateImageBehavior = false;
            this.lvFactura.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            this.columnHeader2.Width = 258;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 269;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 650;
            // 
            // txtFactura
            // 
            this.txtFactura.AutoSize = true;
            this.txtFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(24, 119);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(343, 42);
            this.txtFactura.TabIndex = 1;
            this.txtFactura.Text = "Factura a nombre de: ";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSize = true;
            this.txtCliente.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(359, 120);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(297, 41);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.Text = "Nombre del cliente";
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.Location = new System.Drawing.Point(31, 20);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(114, 49);
            this.btnBackMenu.TabIndex = 12;
            this.btnBackMenu.Text = "Atrás";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtEstadoFactura);
            this.panel1.Controls.Add(this.cmbFormatoPago);
            this.panel1.Controls.Add(this.txtPago);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.txtCodigoFactura);
            this.panel1.Controls.Add(this.btnBackMenu);
            this.panel1.Controls.Add(this.txtFactura);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Location = new System.Drawing.Point(44, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 332);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(721, 126);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(79, 35);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.Text = "Total";
            // 
            // txtEstadoFactura
            // 
            this.txtEstadoFactura.AutoSize = true;
            this.txtEstadoFactura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEstadoFactura.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoFactura.Location = new System.Drawing.Point(262, 26);
            this.txtEstadoFactura.Name = "txtEstadoFactura";
            this.txtEstadoFactura.Size = new System.Drawing.Size(184, 34);
            this.txtEstadoFactura.TabIndex = 16;
            this.txtEstadoFactura.Text = "EstadoFactura";
            // 
            // cmbFormatoPago
            // 
            this.cmbFormatoPago.FormattingEnabled = true;
            this.cmbFormatoPago.Location = new System.Drawing.Point(324, 204);
            this.cmbFormatoPago.Name = "cmbFormatoPago";
            this.cmbFormatoPago.Size = new System.Drawing.Size(224, 37);
            this.cmbFormatoPago.TabIndex = 14;
            // 
            // txtPago
            // 
            this.txtPago.AutoSize = true;
            this.txtPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(24, 197);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(280, 42);
            this.txtPago.TabIndex = 15;
            this.txtPago.Text = "Formato de pago:";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFecha.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(754, 26);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(86, 34);
            this.txtFecha.TabIndex = 14;
            this.txtFecha.Text = "Fecha";
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.AutoSize = true;
            this.txtCodigoFactura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCodigoFactura.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFactura.Location = new System.Drawing.Point(486, 26);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.Size = new System.Drawing.Size(227, 34);
            this.txtCodigoFactura.TabIndex = 13;
            this.txtCodigoFactura.Text = "Código de factura";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(660, 235);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(253, 48);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar Pago";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // Facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 752);
            this.Controls.Add(this.lvFactura);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturación";
            this.Text = "Facturación";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFactura;
        private System.Windows.Forms.Label txtFactura;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label txtCodigoFactura;
        private System.Windows.Forms.ComboBox cmbFormatoPago;
        private System.Windows.Forms.Label txtPago;
        private System.Windows.Forms.Label txtEstadoFactura;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button btnConfirmar;
    }
}