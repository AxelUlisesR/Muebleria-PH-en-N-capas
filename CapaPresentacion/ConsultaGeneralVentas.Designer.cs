namespace CapaPresentacion
{
    partial class ConsultaGeneralVentas
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
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaEnt = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(23, 85);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 72;
            this.dgvReporte.RowTemplate.Height = 31;
            this.dgvReporte.Size = new System.Drawing.Size(1117, 291);
            this.dgvReporte.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(228, 30);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(147, 22);
            this.dtpFecha.TabIndex = 30;
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimite.Location = new System.Drawing.Point(596, 33);
            this.dtpFechaLimite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(147, 22);
            this.dtpFechaLimite.TabIndex = 31;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(84, 33);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 17);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.Text = "Fecha inicial";
            // 
            // lblFechaEnt
            // 
            this.lblFechaEnt.Location = new System.Drawing.Point(465, 33);
            this.lblFechaEnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEnt.Name = "lblFechaEnt";
            this.lblFechaEnt.Size = new System.Drawing.Size(119, 19);
            this.lblFechaEnt.TabIndex = 33;
            this.lblFechaEnt.Text = "Fecha limite";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(189, 388);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(160, 39);
            this.btnConsulta.TabIndex = 34;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(589, 388);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 39);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultaGeneralVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 501);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFechaEnt);
            this.Controls.Add(this.dgvReporte);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultaGeneralVentas";
            this.Text = "ConsultaGeneralVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaEnt;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSalir;
    }
}