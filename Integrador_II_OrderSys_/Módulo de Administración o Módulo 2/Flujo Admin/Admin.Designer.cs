namespace Integrador_II_OrderSys_.Módulo_de_Administración_o_Módulo_2.Flujo_Admin
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBienvenida = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.btnInvLimpiar = new System.Windows.Forms.Button();
            this.btnInvEliminar = new System.Windows.Forms.Button();
            this.btnInvModificar = new System.Windows.Forms.Button();
            this.btnInvAgregar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.txtInvStock = new System.Windows.Forms.TextBox();
            this.txtInvPrecio = new System.Windows.Forms.TextBox();
            this.txtInvDescripcion = new System.Windows.Forms.TextBox();
            this.txtInvCodigo = new System.Windows.Forms.TextBox();
            this.lvInventario = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.lblVentasTotal = new System.Windows.Forms.Label();
            this.btnVentasAnular = new System.Windows.Forms.Button();
            this.btnVentasDetalle = new System.Windows.Forms.Button();
            this.lvVentas = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVentasFiltrar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.btnGuardarReporte = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dtpRepHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpRepDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbRepMesero = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.txtBienvenida);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 175);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(13, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 48);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtBienvenida
            // 
            this.txtBienvenida.AutoSize = true;
            this.txtBienvenida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBienvenida.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienvenida.Location = new System.Drawing.Point(314, 62);
            this.txtBienvenida.Name = "txtBienvenida";
            this.txtBienvenida.Size = new System.Drawing.Size(364, 50);
            this.txtBienvenida.TabIndex = 0;
            this.txtBienvenida.Text = "Bienvenido, Admin";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabInventario);
            this.tabAdmin.Controls.Add(this.tabVentas);
            this.tabAdmin.Controls.Add(this.tabReportes);
            this.tabAdmin.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(27, 193);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(966, 807);
            this.tabAdmin.TabIndex = 2;
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.btnInvLimpiar);
            this.tabInventario.Controls.Add(this.btnInvEliminar);
            this.tabInventario.Controls.Add(this.btnInvModificar);
            this.tabInventario.Controls.Add(this.btnInvAgregar);
            this.tabInventario.Controls.Add(this.txtStock);
            this.tabInventario.Controls.Add(this.txtDescripcion);
            this.tabInventario.Controls.Add(this.txtPrecio);
            this.tabInventario.Controls.Add(this.txtCodigo);
            this.tabInventario.Controls.Add(this.txtInvStock);
            this.tabInventario.Controls.Add(this.txtInvPrecio);
            this.tabInventario.Controls.Add(this.txtInvDescripcion);
            this.tabInventario.Controls.Add(this.txtInvCodigo);
            this.tabInventario.Controls.Add(this.lvInventario);
            this.tabInventario.Location = new System.Drawing.Point(10, 52);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(946, 745);
            this.tabInventario.TabIndex = 0;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            this.tabInventario.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // btnInvLimpiar
            // 
            this.btnInvLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvLimpiar.Location = new System.Drawing.Point(724, 631);
            this.btnInvLimpiar.Name = "btnInvLimpiar";
            this.btnInvLimpiar.Size = new System.Drawing.Size(148, 65);
            this.btnInvLimpiar.TabIndex = 16;
            this.btnInvLimpiar.Text = "Limpiar";
            this.btnInvLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnInvEliminar
            // 
            this.btnInvEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvEliminar.Location = new System.Drawing.Point(521, 631);
            this.btnInvEliminar.Name = "btnInvEliminar";
            this.btnInvEliminar.Size = new System.Drawing.Size(148, 65);
            this.btnInvEliminar.TabIndex = 15;
            this.btnInvEliminar.Text = "Eliminar";
            this.btnInvEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInvModificar
            // 
            this.btnInvModificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvModificar.Location = new System.Drawing.Point(276, 631);
            this.btnInvModificar.Name = "btnInvModificar";
            this.btnInvModificar.Size = new System.Drawing.Size(175, 65);
            this.btnInvModificar.TabIndex = 14;
            this.btnInvModificar.Text = "Modificar";
            this.btnInvModificar.UseVisualStyleBackColor = true;
            // 
            // btnInvAgregar
            // 
            this.btnInvAgregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvAgregar.Location = new System.Drawing.Point(65, 631);
            this.btnInvAgregar.Name = "btnInvAgregar";
            this.btnInvAgregar.Size = new System.Drawing.Size(148, 65);
            this.btnInvAgregar.TabIndex = 13;
            this.btnInvAgregar.Text = "Agregar";
            this.btnInvAgregar.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(504, 488);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(96, 42);
            this.txtStock.TabIndex = 12;
            this.txtStock.Text = "Stock";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(475, 378);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(194, 42);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(58, 495);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(112, 42);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(58, 371);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(125, 42);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.Text = "Código";
            // 
            // txtInvStock
            // 
            this.txtInvStock.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvStock.Location = new System.Drawing.Point(704, 488);
            this.txtInvStock.Name = "txtInvStock";
            this.txtInvStock.Size = new System.Drawing.Size(168, 49);
            this.txtInvStock.TabIndex = 8;
            // 
            // txtInvPrecio
            // 
            this.txtInvPrecio.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvPrecio.Location = new System.Drawing.Point(245, 488);
            this.txtInvPrecio.Name = "txtInvPrecio";
            this.txtInvPrecio.Size = new System.Drawing.Size(168, 49);
            this.txtInvPrecio.TabIndex = 7;
            // 
            // txtInvDescripcion
            // 
            this.txtInvDescripcion.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvDescripcion.Location = new System.Drawing.Point(704, 371);
            this.txtInvDescripcion.Name = "txtInvDescripcion";
            this.txtInvDescripcion.Size = new System.Drawing.Size(168, 49);
            this.txtInvDescripcion.TabIndex = 6;
            // 
            // txtInvCodigo
            // 
            this.txtInvCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvCodigo.Location = new System.Drawing.Point(245, 371);
            this.txtInvCodigo.Name = "txtInvCodigo";
            this.txtInvCodigo.Size = new System.Drawing.Size(168, 49);
            this.txtInvCodigo.TabIndex = 5;
            // 
            // lvInventario
            // 
            this.lvInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvInventario.HideSelection = false;
            this.lvInventario.Location = new System.Drawing.Point(23, 26);
            this.lvInventario.Name = "lvInventario";
            this.lvInventario.Size = new System.Drawing.Size(901, 280);
            this.lvInventario.TabIndex = 0;
            this.lvInventario.UseCompatibleStateImageBehavior = false;
            this.lvInventario.SelectedIndexChanged += new System.EventHandler(this.lvInventario_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stock";
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.lblVentasTotal);
            this.tabVentas.Controls.Add(this.btnVentasAnular);
            this.tabVentas.Controls.Add(this.btnVentasDetalle);
            this.tabVentas.Controls.Add(this.lvVentas);
            this.tabVentas.Controls.Add(this.btnVentasFiltrar);
            this.tabVentas.Controls.Add(this.dtpHasta);
            this.tabVentas.Controls.Add(this.dtpDesde);
            this.tabVentas.Location = new System.Drawing.Point(10, 52);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(946, 745);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // lblVentasTotal
            // 
            this.lblVentasTotal.AutoSize = true;
            this.lblVentasTotal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasTotal.Location = new System.Drawing.Point(683, 623);
            this.lblVentasTotal.Name = "lblVentasTotal";
            this.lblVentasTotal.Size = new System.Drawing.Size(221, 41);
            this.lblVentasTotal.TabIndex = 6;
            this.lblVentasTotal.Text = "Ventas totales";
            this.lblVentasTotal.Click += new System.EventHandler(this.txtVentasTotal_Click);
            // 
            // btnVentasAnular
            // 
            this.btnVentasAnular.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasAnular.Location = new System.Drawing.Point(337, 612);
            this.btnVentasAnular.Name = "btnVentasAnular";
            this.btnVentasAnular.Size = new System.Drawing.Size(251, 67);
            this.btnVentasAnular.TabIndex = 5;
            this.btnVentasAnular.Text = "Anular ventas";
            this.btnVentasAnular.UseVisualStyleBackColor = true;
            // 
            // btnVentasDetalle
            // 
            this.btnVentasDetalle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasDetalle.Location = new System.Drawing.Point(36, 612);
            this.btnVentasDetalle.Name = "btnVentasDetalle";
            this.btnVentasDetalle.Size = new System.Drawing.Size(251, 67);
            this.btnVentasDetalle.TabIndex = 4;
            this.btnVentasDetalle.Text = "Detalles de ventas";
            this.btnVentasDetalle.UseVisualStyleBackColor = true;
            // 
            // lvVentas
            // 
            this.lvVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvVentas.HideSelection = false;
            this.lvVentas.Location = new System.Drawing.Point(36, 129);
            this.lvVentas.Name = "lvVentas";
            this.lvVentas.Size = new System.Drawing.Size(881, 451);
            this.lvVentas.TabIndex = 3;
            this.lvVentas.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Código";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mesa";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cliente";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Atiende";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Pago";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Total";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Estado";
            // 
            // btnVentasFiltrar
            // 
            this.btnVentasFiltrar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasFiltrar.Location = new System.Drawing.Point(690, 32);
            this.btnVentasFiltrar.Name = "btnVentasFiltrar";
            this.btnVentasFiltrar.Size = new System.Drawing.Size(228, 53);
            this.btnVentasFiltrar.TabIndex = 2;
            this.btnVentasFiltrar.Text = "Filtrar ventas";
            this.btnVentasFiltrar.UseVisualStyleBackColor = true;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(322, 32);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 42);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(36, 32);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 42);
            this.dtpDesde.TabIndex = 0;
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.btnGuardarReporte);
            this.tabReportes.Controls.Add(this.txtReporte);
            this.tabReportes.Controls.Add(this.btnGenerarReporte);
            this.tabReportes.Controls.Add(this.dtpRepHasta);
            this.tabReportes.Controls.Add(this.dtpRepDesde);
            this.tabReportes.Controls.Add(this.cmbRepMesero);
            this.tabReportes.Location = new System.Drawing.Point(10, 52);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportes.Size = new System.Drawing.Size(946, 745);
            this.tabReportes.TabIndex = 2;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // btnGuardarReporte
            // 
            this.btnGuardarReporte.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReporte.Location = new System.Drawing.Point(32, 661);
            this.btnGuardarReporte.Name = "btnGuardarReporte";
            this.btnGuardarReporte.Size = new System.Drawing.Size(281, 60);
            this.btnGuardarReporte.TabIndex = 6;
            this.btnGuardarReporte.Text = "Guardar reporte";
            this.btnGuardarReporte.UseVisualStyleBackColor = true;
            // 
            // txtReporte
            // 
            this.txtReporte.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.Location = new System.Drawing.Point(32, 270);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(880, 360);
            this.txtReporte.TabIndex = 5;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(32, 179);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(281, 60);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // dtpRepHasta
            // 
            this.dtpRepHasta.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRepHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRepHasta.Location = new System.Drawing.Point(712, 34);
            this.dtpRepHasta.Name = "dtpRepHasta";
            this.dtpRepHasta.Size = new System.Drawing.Size(200, 49);
            this.dtpRepHasta.TabIndex = 2;
            // 
            // dtpRepDesde
            // 
            this.dtpRepDesde.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRepDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRepDesde.Location = new System.Drawing.Point(401, 34);
            this.dtpRepDesde.Name = "dtpRepDesde";
            this.dtpRepDesde.Size = new System.Drawing.Size(200, 49);
            this.dtpRepDesde.TabIndex = 1;
            // 
            // cmbRepMesero
            // 
            this.cmbRepMesero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepMesero.FormattingEnabled = true;
            this.cmbRepMesero.Location = new System.Drawing.Point(32, 34);
            this.cmbRepMesero.Name = "cmbRepMesero";
            this.cmbRepMesero.Size = new System.Drawing.Size(188, 50);
            this.cmbRepMesero.TabIndex = 0;
            this.cmbRepMesero.Text = "Mesero";
            this.cmbRepMesero.SelectedIndexChanged += new System.EventHandler(this.cmbRepMesero_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 1025);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Pagina_Principal";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabInventario.ResumeLayout(false);
            this.tabInventario.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.tabReportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtBienvenida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.ListView lvInventario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtInvStock;
        private System.Windows.Forms.TextBox txtInvPrecio;
        private System.Windows.Forms.TextBox txtInvDescripcion;
        private System.Windows.Forms.TextBox txtInvCodigo;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Button btnInvLimpiar;
        private System.Windows.Forms.Button btnInvEliminar;
        private System.Windows.Forms.Button btnInvModificar;
        private System.Windows.Forms.Button btnInvAgregar;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.Button btnVentasFiltrar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnVentasDetalle;
        private System.Windows.Forms.ListView lvVentas;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lblVentasTotal;
        private System.Windows.Forms.Button btnVentasAnular;
        private System.Windows.Forms.ComboBox cmbRepMesero;
        private System.Windows.Forms.DateTimePicker dtpRepDesde;
        private System.Windows.Forms.DateTimePicker dtpRepHasta;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnGuardarReporte;
    }
}