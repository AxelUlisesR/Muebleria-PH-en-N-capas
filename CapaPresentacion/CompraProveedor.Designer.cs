namespace CapaPresentacion
{
    partial class CompraProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.idProveedortxt = new System.Windows.Forms.TextBox();
            this.Proveedor = new System.Windows.Forms.GroupBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.lblNoOrden = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Proveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(563, 106);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 29);
            this.txtPrecio.TabIndex = 64;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(14, 230);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(933, 94);
            this.txtDescripcion.TabIndex = 57;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Location = new System.Drawing.Point(112, 50);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(250, 32);
            this.cboCategoria.TabIndex = 53;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboProducto
            // 
            this.cboProducto.Location = new System.Drawing.Point(112, 103);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(245, 32);
            this.cboProducto.TabIndex = 54;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 152);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(134, 29);
            this.txtCantidad.TabIndex = 55;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(563, 152);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(138, 29);
            this.txtStock.TabIndex = 56;
            // 
            // lblCat
            // 
            this.lblCat.Location = new System.Drawing.Point(9, 53);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(100, 23);
            this.lblCat.TabIndex = 58;
            this.lblCat.Text = "Categoría";
            // 
            // lblProd
            // 
            this.lblProd.Location = new System.Drawing.Point(9, 103);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(100, 23);
            this.lblProd.TabIndex = 60;
            this.lblProd.Text = "Producto";
            // 
            // lblCant
            // 
            this.lblCant.Location = new System.Drawing.Point(13, 151);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(100, 23);
            this.lblCant.TabIndex = 61;
            this.lblCant.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(380, 103);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(154, 23);
            this.lblPrecio.TabIndex = 62;
            this.lblPrecio.Text = "Precio de venta";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(403, 151);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(131, 23);
            this.lblStock.TabIndex = 63;
            this.lblStock.Text = "Stock actual";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(809, 114);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(138, 29);
            this.maskedTextBox1.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(739, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Costo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCant);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblProd);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblCat);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Location = new System.Drawing.Point(135, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 352);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(809, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 46);
            this.btnOK.TabIndex = 78;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(590, 90);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(99, 25);
            this.lblDir.TabIndex = 68;
            this.lblDir.Text = "Dirección:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(590, 40);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(95, 25);
            this.lblTel.TabIndex = 69;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 70;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(132, 25);
            this.lblID.TabIndex = 71;
            this.lblID.Text = "ID Proveedor:";
            // 
            // txtDir
            // 
            this.txtDir.Enabled = false;
            this.txtDir.Location = new System.Drawing.Point(730, 87);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(300, 29);
            this.txtDir.TabIndex = 72;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(730, 37);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 29);
            this.txtTel.TabIndex = 73;
            // 
            // idProveedortxt
            // 
            this.idProveedortxt.Enabled = false;
            this.idProveedortxt.Location = new System.Drawing.Point(147, 88);
            this.idProveedortxt.Name = "idProveedortxt";
            this.idProveedortxt.ReadOnly = true;
            this.idProveedortxt.Size = new System.Drawing.Size(100, 29);
            this.idProveedortxt.TabIndex = 75;
            // 
            // Proveedor
            // 
            this.Proveedor.Controls.Add(this.cboProveedor);
            this.Proveedor.Controls.Add(this.txtDir);
            this.Proveedor.Controls.Add(this.lblDir);
            this.Proveedor.Controls.Add(this.idProveedortxt);
            this.Proveedor.Controls.Add(this.lblTel);
            this.Proveedor.Controls.Add(this.lblNombre);
            this.Proveedor.Controls.Add(this.txtTel);
            this.Proveedor.Controls.Add(this.lblID);
            this.Proveedor.Location = new System.Drawing.Point(135, 65);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(1077, 136);
            this.Proveedor.TabIndex = 76;
            this.Proveedor.TabStop = false;
            this.Proveedor.Text = "Proveedor";
            // 
            // cboProveedor
            // 
            this.cboProveedor.Location = new System.Drawing.Point(147, 39);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(398, 32);
            this.cboProveedor.TabIndex = 79;
            this.cboProveedor.SelectedIndexChanged += new System.EventHandler(this.cboProveedor_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 617);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 348);
            this.dataGridView1.TabIndex = 77;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(543, 1107);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(117, 40);
            this.btnConsulta.TabIndex = 82;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(323, 1032);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 40);
            this.btnNuevo.TabIndex = 81;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(440, 1032);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 40);
            this.btnGrabar.TabIndex = 78;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(555, 1032);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(669, 1032);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 40);
            this.btnSalir.TabIndex = 80;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(29, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(468, 50);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "COMPRA A PROVEEDOR";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(711, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpFecha.TabIndex = 84;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(554, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 85;
            this.lblFecha.Text = "Fecha";
            // 
            // idtxt
            // 
            this.idtxt.Enabled = false;
            this.idtxt.Location = new System.Drawing.Point(1112, 21);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(100, 29);
            this.idtxt.TabIndex = 80;
            // 
            // lblNoOrden
            // 
            this.lblNoOrden.Location = new System.Drawing.Point(1022, 24);
            this.lblNoOrden.Name = "lblNoOrden";
            this.lblNoOrden.Size = new System.Drawing.Size(100, 23);
            this.lblNoOrden.TabIndex = 81;
            this.lblNoOrden.Text = "No. Orden";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(1036, 971);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(176, 29);
            this.txtSubtotal.TabIndex = 100;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(1036, 1006);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(176, 29);
            this.txtIVA.TabIndex = 101;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1036, 1041);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(176, 29);
            this.txtTotal.TabIndex = 102;
            // 
            // lblSub
            // 
            this.lblSub.Location = new System.Drawing.Point(930, 971);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(100, 23);
            this.lblSub.TabIndex = 103;
            this.lblSub.Text = "Subtotal";
            // 
            // lblIVA
            // 
            this.lblIVA.Location = new System.Drawing.Point(937, 1009);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(100, 23);
            this.lblIVA.TabIndex = 104;
            this.lblIVA.Text = "IVA";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(930, 1044);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 105;
            this.lblTotal.Text = "Total";
            // 
            // CompraProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1387, 1244);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.lblNoOrden);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Proveedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompraProveedor";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Text = "CompraProveedor";
            this.Load += new System.EventHandler(this.CompraProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Proveedor.ResumeLayout(false);
            this.Proveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox idProveedortxt;
        private System.Windows.Forms.GroupBox Proveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label lblNoOrden;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
    }
}