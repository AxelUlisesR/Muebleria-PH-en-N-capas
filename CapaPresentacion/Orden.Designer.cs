namespace CapaPresentacion
{
    partial class Orden
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.idtxt = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtDirCliente = new System.Windows.Forms.TextBox();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.txtRFCCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.txtComisionVendedor = new System.Windows.Forms.TextBox();
            this.txtTelVendedor = new System.Windows.Forms.TextBox();
            this.cboRepartidor = new System.Windows.Forms.ComboBox();
            this.txtTelRepartidor = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNoOrden = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaEnt = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblTelVen = new System.Windows.Forms.Label();
            this.lblRepartidor = new System.Windows.Forms.Label();
            this.lblTelRep = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idtxt
            // 
            this.idtxt.Enabled = false;
            this.idtxt.Location = new System.Drawing.Point(1313, 38);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(100, 29);
            this.idtxt.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(440, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpFecha.TabIndex = 1;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(946, 37);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(200, 29);
            this.dtpEntrega.TabIndex = 2;
            // 
            // cboCliente
            // 
            this.cboCliente.Location = new System.Drawing.Point(124, 34);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(355, 32);
            this.cboCliente.TabIndex = 3;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // txtDirCliente
            // 
            this.txtDirCliente.Enabled = false;
            this.txtDirCliente.Location = new System.Drawing.Point(124, 82);
            this.txtDirCliente.Multiline = true;
            this.txtDirCliente.Name = "txtDirCliente";
            this.txtDirCliente.Size = new System.Drawing.Size(355, 67);
            this.txtDirCliente.TabIndex = 4;
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Enabled = false;
            this.txtTelCliente.Location = new System.Drawing.Point(603, 34);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(255, 29);
            this.txtTelCliente.TabIndex = 5;
            // 
            // txtRFCCliente
            // 
            this.txtRFCCliente.Enabled = false;
            this.txtRFCCliente.Location = new System.Drawing.Point(603, 77);
            this.txtRFCCliente.Name = "txtRFCCliente";
            this.txtRFCCliente.Size = new System.Drawing.Size(255, 29);
            this.txtRFCCliente.TabIndex = 6;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Enabled = false;
            this.txtCorreoCliente.Location = new System.Drawing.Point(1013, 37);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(305, 29);
            this.txtCorreoCliente.TabIndex = 7;
            // 
            // cboVendedor
            // 
            this.cboVendedor.Location = new System.Drawing.Point(124, 33);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(357, 32);
            this.cboVendedor.TabIndex = 8;
            this.cboVendedor.SelectedIndexChanged += new System.EventHandler(this.cboVendedor_SelectedIndexChanged);
            // 
            // txtComisionVendedor
            // 
            this.txtComisionVendedor.Enabled = false;
            this.txtComisionVendedor.Location = new System.Drawing.Point(1013, 39);
            this.txtComisionVendedor.Name = "txtComisionVendedor";
            this.txtComisionVendedor.Size = new System.Drawing.Size(164, 29);
            this.txtComisionVendedor.TabIndex = 9;
            // 
            // txtTelVendedor
            // 
            this.txtTelVendedor.Enabled = false;
            this.txtTelVendedor.Location = new System.Drawing.Point(603, 39);
            this.txtTelVendedor.Name = "txtTelVendedor";
            this.txtTelVendedor.Size = new System.Drawing.Size(255, 29);
            this.txtTelVendedor.TabIndex = 10;
            // 
            // cboRepartidor
            // 
            this.cboRepartidor.Location = new System.Drawing.Point(117, 47);
            this.cboRepartidor.Name = "cboRepartidor";
            this.cboRepartidor.Size = new System.Drawing.Size(362, 32);
            this.cboRepartidor.TabIndex = 11;
            this.cboRepartidor.SelectedIndexChanged += new System.EventHandler(this.cboRepartidor_SelectedIndexChanged);
            // 
            // txtTelRepartidor
            // 
            this.txtTelRepartidor.Enabled = false;
            this.txtTelRepartidor.Location = new System.Drawing.Point(603, 44);
            this.txtTelRepartidor.Name = "txtTelRepartidor";
            this.txtTelRepartidor.Size = new System.Drawing.Size(255, 29);
            this.txtTelRepartidor.TabIndex = 12;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Location = new System.Drawing.Point(121, 514);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(250, 32);
            this.cboCategoria.TabIndex = 13;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboProducto
            // 
            this.cboProducto.Location = new System.Drawing.Point(121, 567);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(245, 32);
            this.cboProducto.TabIndex = 14;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(124, 613);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 29);
            this.txtCantidad.TabIndex = 15;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(445, 604);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(138, 29);
            this.txtStock.TabIndex = 17;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(614, 556);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 46);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeight = 40;
            this.dgvDetalle.Location = new System.Drawing.Point(580, 658);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 72;
            this.dgvDetalle.Size = new System.Drawing.Size(939, 296);
            this.dgvDetalle.TabIndex = 19;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(726, 977);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(138, 29);
            this.txtSubtotal.TabIndex = 20;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(919, 977);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(138, 29);
            this.txtIVA.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1167, 977);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(176, 29);
            this.txtTotal.TabIndex = 22;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(151, 933);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 40);
            this.btnGrabar.TabIndex = 23;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(266, 933);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(380, 933);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 40);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(50, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 50);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "ORDENES";
            // 
            // lblNoOrden
            // 
            this.lblNoOrden.Location = new System.Drawing.Point(1223, 41);
            this.lblNoOrden.Name = "lblNoOrden";
            this.lblNoOrden.Size = new System.Drawing.Size(100, 23);
            this.lblNoOrden.TabIndex = 27;
            this.lblNoOrden.Text = "No. Orden";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(283, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha";
            // 
            // lblFechaEnt
            // 
            this.lblFechaEnt.Location = new System.Drawing.Point(766, 37);
            this.lblFechaEnt.Name = "lblFechaEnt";
            this.lblFechaEnt.Size = new System.Drawing.Size(163, 29);
            this.lblFechaEnt.TabIndex = 29;
            this.lblFechaEnt.Text = "Fecha Entrega";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(13, 37);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(100, 23);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(11, 85);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(111, 23);
            this.lblDireccion.TabIndex = 31;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelCli
            // 
            this.lblTelCli.Location = new System.Drawing.Point(497, 37);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(100, 23);
            this.lblTelCli.TabIndex = 32;
            this.lblTelCli.Text = "Teléfono";
            // 
            // lblRFC
            // 
            this.lblRFC.Location = new System.Drawing.Point(502, 83);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(100, 23);
            this.lblRFC.TabIndex = 33;
            this.lblRFC.Text = "RFC";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(907, 37);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(100, 23);
            this.lblCorreo.TabIndex = 34;
            this.lblCorreo.Text = "Correo";
            // 
            // lblVendedor
            // 
            this.lblVendedor.Location = new System.Drawing.Point(11, 39);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(100, 23);
            this.lblVendedor.TabIndex = 35;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblComision
            // 
            this.lblComision.Location = new System.Drawing.Point(907, 39);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(100, 23);
            this.lblComision.TabIndex = 36;
            this.lblComision.Text = "Comisión";
            // 
            // lblTelVen
            // 
            this.lblTelVen.Location = new System.Drawing.Point(497, 39);
            this.lblTelVen.Name = "lblTelVen";
            this.lblTelVen.Size = new System.Drawing.Size(100, 23);
            this.lblTelVen.TabIndex = 37;
            this.lblTelVen.Text = "Teléfono";
            // 
            // lblRepartidor
            // 
            this.lblRepartidor.Location = new System.Drawing.Point(4, 50);
            this.lblRepartidor.Name = "lblRepartidor";
            this.lblRepartidor.Size = new System.Drawing.Size(109, 23);
            this.lblRepartidor.TabIndex = 38;
            this.lblRepartidor.Text = "Repartidor";
            // 
            // lblTelRep
            // 
            this.lblTelRep.Location = new System.Drawing.Point(497, 50);
            this.lblTelRep.Name = "lblTelRep";
            this.lblTelRep.Size = new System.Drawing.Size(100, 23);
            this.lblTelRep.TabIndex = 39;
            this.lblTelRep.Text = "Teléfono";
            // 
            // lblCat
            // 
            this.lblCat.Location = new System.Drawing.Point(18, 517);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(100, 23);
            this.lblCat.TabIndex = 40;
            this.lblCat.Text = "Categoría";
            // 
            // lblProd
            // 
            this.lblProd.Location = new System.Drawing.Point(18, 567);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(100, 23);
            this.lblProd.TabIndex = 41;
            this.lblProd.Text = "Producto";
            // 
            // lblCant
            // 
            this.lblCant.Location = new System.Drawing.Point(34, 616);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(100, 23);
            this.lblCant.TabIndex = 42;
            this.lblCant.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(375, 567);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 23);
            this.lblPrecio.TabIndex = 43;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(375, 610);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(100, 23);
            this.lblStock.TabIndex = 44;
            this.lblStock.Text = "Stock";
            // 
            // lblSub
            // 
            this.lblSub.Location = new System.Drawing.Point(620, 977);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(100, 23);
            this.lblSub.TabIndex = 45;
            this.lblSub.Text = "Subtotal";
            // 
            // lblIVA
            // 
            this.lblIVA.Location = new System.Drawing.Point(870, 980);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(100, 23);
            this.lblIVA.TabIndex = 46;
            this.lblIVA.Text = "IVA";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(1097, 980);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCorreoCliente);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.lblRFC);
            this.groupBox1.Controls.Add(this.lblTelCli);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtDirCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtTelCliente);
            this.groupBox1.Controls.Add(this.txtRFCCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1340, 155);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboVendedor);
            this.groupBox2.Controls.Add(this.lblTelVen);
            this.groupBox2.Controls.Add(this.lblComision);
            this.groupBox2.Controls.Add(this.lblVendedor);
            this.groupBox2.Controls.Add(this.txtComisionVendedor);
            this.groupBox2.Controls.Add(this.txtTelVendedor);
            this.groupBox2.Location = new System.Drawing.Point(23, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1340, 99);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendedor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRepartidor);
            this.groupBox3.Controls.Add(this.cboRepartidor);
            this.groupBox3.Controls.Add(this.lblTelRep);
            this.groupBox3.Controls.Add(this.txtTelRepartidor);
            this.groupBox3.Location = new System.Drawing.Point(25, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1340, 99);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repartidor";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(34, 933);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 40);
            this.btnNuevo.TabIndex = 51;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(445, 561);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 29);
            this.txtPrecio.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(25, 704);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(384, 136);
            this.txtDescripcion.TabIndex = 40;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(380, 1008);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(117, 40);
            this.btnConsulta.TabIndex = 53;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 1008);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 40);
            this.button1.TabIndex = 54;
            this.button1.Text = "Consulta general";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1576, 1065);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNoOrden);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFechaEnt);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblTotal);
            this.Name = "Orden";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Text = "Ventas - Mueblería PH";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo, lblNoOrden, lblFecha, lblFechaEnt, lblCliente, lblDireccion, lblTelCli, lblRFC, lblCorreo, lblVendedor, lblComision, lblTelVen, lblRepartidor, lblTelRep, lblCat, lblProd, lblCant, lblPrecio, lblStock, lblSub, lblIVA, lblTotal;
        private System.Windows.Forms.TextBox idtxt, txtDirCliente, txtTelCliente, txtRFCCliente, txtCorreoCliente, txtComisionVendedor, txtTelVendedor, txtTelRepartidor, txtCantidad, txtStock, txtSubtotal, txtIVA, txtTotal;
        private System.Windows.Forms.ComboBox cboCliente, cboVendedor, cboRepartidor, cboCategoria, cboProducto;
        private System.Windows.Forms.DateTimePicker dtpFecha, dtpEntrega;
        private System.Windows.Forms.Button btnOK, btnGrabar, btnCancelar, btnSalir;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button button1;
    }
}