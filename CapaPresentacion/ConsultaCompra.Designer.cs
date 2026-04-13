namespace CapaPresentacion
{
    partial class ConsultaCompra
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
            this.lblNoOrden = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Proveedor = new System.Windows.Forms.GroupBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.idProveedortxt = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Proveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoOrden
            // 
            this.lblNoOrden.Location = new System.Drawing.Point(1039, 46);
            this.lblNoOrden.Name = "lblNoOrden";
            this.lblNoOrden.Size = new System.Drawing.Size(100, 23);
            this.lblNoOrden.TabIndex = 90;
            this.lblNoOrden.Text = "No. Orden";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(46, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(468, 50);
            this.lblTitulo.TabIndex = 91;
            this.lblTitulo.Text = "COMPRA A PROVEEDOR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 500);
            this.dataGridView1.TabIndex = 88;
            // 
            // Proveedor
            // 
            this.Proveedor.Controls.Add(this.txtNombreProveedor);
            this.Proveedor.Controls.Add(this.txtDir);
            this.Proveedor.Controls.Add(this.lblDir);
            this.Proveedor.Controls.Add(this.idProveedortxt);
            this.Proveedor.Controls.Add(this.lblTel);
            this.Proveedor.Controls.Add(this.lblNombre);
            this.Proveedor.Controls.Add(this.txtTel);
            this.Proveedor.Controls.Add(this.lblID);
            this.Proveedor.Location = new System.Drawing.Point(152, 87);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(1077, 136);
            this.Proveedor.TabIndex = 87;
            this.Proveedor.TabStop = false;
            this.Proveedor.Text = "Proveedor";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Enabled = false;
            this.txtNombreProveedor.Location = new System.Drawing.Point(134, 46);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(327, 29);
            this.txtNombreProveedor.TabIndex = 76;
            // 
            // txtDir
            // 
            this.txtDir.Enabled = false;
            this.txtDir.Location = new System.Drawing.Point(648, 89);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(300, 29);
            this.txtDir.TabIndex = 72;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(508, 92);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(99, 25);
            this.lblDir.TabIndex = 68;
            this.lblDir.Text = "Dirección:";
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
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(508, 42);
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
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(648, 39);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 29);
            this.txtTel.TabIndex = 73;
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
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(1129, 43);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 29);
            this.idtxt.TabIndex = 89;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(665, 52);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(255, 29);
            this.dtpFecha.TabIndex = 92;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(581, 58);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 93;
            this.lblFecha.Text = "Fecha";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(140, 817);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(132, 40);
            this.btnConsultar.TabIndex = 100;
            this.btnConsultar.Text = "Consultar:";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(286, 817);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 40);
            this.btnSalir.TabIndex = 101;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(1053, 777);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(176, 29);
            this.txtSubtotal.TabIndex = 94;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(1053, 812);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(176, 29);
            this.txtIVA.TabIndex = 95;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1053, 847);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(176, 29);
            this.txtTotal.TabIndex = 96;
            // 
            // lblSub
            // 
            this.lblSub.Location = new System.Drawing.Point(947, 777);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(100, 23);
            this.lblSub.TabIndex = 97;
            this.lblSub.Text = "Subtotal";
            // 
            // lblIVA
            // 
            this.lblIVA.Location = new System.Drawing.Point(954, 815);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(100, 23);
            this.lblIVA.TabIndex = 98;
            this.lblIVA.Text = "IVA";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(947, 850);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "Total";
            // 
            // ConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 1021);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.lblNoOrden);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Proveedor);
            this.Name = "ConsultaCompra";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Text = "ConsultaCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Proveedor.ResumeLayout(false);
            this.Proveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNoOrden;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Proveedor;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox idProveedortxt;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
    }
}