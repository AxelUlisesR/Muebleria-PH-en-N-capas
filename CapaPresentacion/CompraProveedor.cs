using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CapaNegocio;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CompraProveedor : Form
    {
        private CompraProveedorCN nCompra = new CompraProveedorCN();
        private DataTable dtCarrito;

        public CompraProveedor()
        {
            InitializeComponent();
        }

        private void CompraProveedor_Load(object sender, EventArgs e)
        {
            ConfigurarCarrito();
            DesactivarControles();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text)) return;

            int id = (int)cboProducto.SelectedValue;
            string nombre = cboProducto.Text;
            int cant = int.Parse(txtCantidad.Text);
            double costo = double.Parse(maskedTextBox1.Text);

            bool existe = false;
            foreach (DataRow fila in dtCarrito.Rows)
            {
                if (Convert.ToInt32(fila["idProducto"]) == id)
                {
                    fila["Cantidad"] = Convert.ToInt32(fila["Cantidad"]) + cant;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dtCarrito.Rows.Add(id, nombre, cant, costo);
            }

            CalcularTotales();
            cboProducto.SelectedIndex = -1;
            txtCantidad.Clear();
        }

        private void ConfigurarCarrito()
        {
            dtCarrito = new DataTable();
            dtCarrito.Columns.Add("idProducto", typeof(int));
            dtCarrito.Columns.Add("Nombre", typeof(string));
            dtCarrito.Columns.Add("Cantidad", typeof(int));
            dtCarrito.Columns.Add("Costo", typeof(double));
            dataGridView1.DataSource = dtCarrito;
        }

        private void DesactivarControles()
        {
            dtpFecha.Enabled = false;
            cboProveedor.Enabled = false;
            cboCategoria.Enabled = false;
            cboProducto.Enabled = false;
            txtCantidad.Enabled = false;
            btnOK.Enabled = false;
            btnGrabar.Enabled = false;

            cboProveedor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
        }

        private void LimpiarControles()
        {
            txtTel.Clear();
            idProveedortxt.Clear();
            txtDir.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtDescripcion.Clear();
            maskedTextBox1.Clear();
            txtSubtotal.Clear();
            txtIVA.Clear();
            txtTotal.Clear();
            if (dtCarrito != null) dtCarrito.Rows.Clear();
        }

        private void CargarCombos()
        {
            cboProveedor.DataSource = nCompra.CargarCombo("CargarProveedores");
            cboProveedor.DisplayMember = "nombre";
            cboProveedor.ValueMember = "idProveedor";

            cboCategoria.DataSource = nCompra.CargarCombo("CargarCategorias");
            cboCategoria.DisplayMember = "concepto";
            cboCategoria.ValueMember = "idCategoria";

            cboProveedor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarCombos();
            dtpFecha.Enabled = true;
            cboProveedor.Enabled = true;
            cboCategoria.Enabled = true;
            cboProducto.Enabled = true;
            txtCantidad.Enabled = true;
            btnOK.Enabled = true;
            btnGrabar.Enabled = true;

            LimpiarControles();
            idtxt.Text = nCompra.SiguienteID().ToString();
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProveedor.SelectedIndex != -1 && cboProveedor.SelectedItem is DataRowView)
            {
                DataRowView row = (DataRowView)cboProveedor.SelectedItem;
                idProveedortxt.Text = row["idProveedor"].ToString();
                txtTel.Text = row["telefono"].ToString();
                txtDir.Text = row["direccion"].ToString();
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex != -1 && cboCategoria.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cboCategoria.SelectedItem;
                int idCat = Convert.ToInt32(drv["idCategoria"]);

                cboProducto.DataSource = nCompra.FiltrarProductos(idCat);
                cboProducto.DisplayMember = "nombre";
                cboProducto.ValueMember = "idProducto";

                cboProducto.SelectedIndex = -1;
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex != -1 && cboProducto.SelectedItem is DataRowView)
            {
                DataRowView row = (DataRowView)cboProducto.SelectedItem;
                txtPrecio.Text = row["precio"].ToString();
                txtStock.Text = row["stock"].ToString();
                txtDescripcion.Text = row["descripcion"].ToString();
                maskedTextBox1.Text = row["costo"].ToString();
            }
            else
            {
                txtPrecio.Clear();
                txtStock.Clear();
                txtDescripcion.Clear();
                maskedTextBox1.Clear();
            }
        }

        private void CalcularTotales()
        {
            double subtotal = 0;
            foreach (DataRow fila in dtCarrito.Rows)
            {
                int cantidad = Convert.ToInt32(fila["Cantidad"]);
                double costo = Convert.ToDouble(fila["Costo"]);
                subtotal += (cantidad * costo);
            }

            double iva = subtotal * 0.16;
            double total = subtotal + iva;

            txtSubtotal.Text = subtotal.ToString("0.00");
            txtIVA.Text = iva.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidad.CompraProveedor c = new CapaEntidad.CompraProveedor();
                c.IdProveedor = (int)cboProveedor.SelectedValue;
                c.Fecha = dtpFecha.Value;
                c.Total = double.Parse(txtTotal.Text);

                DataTable dtSQL = new DataTable();
                dtSQL.Columns.Add("idProducto", typeof(int));
                dtSQL.Columns.Add("cantidad", typeof(int));
                dtSQL.Columns.Add("precio", typeof(double));

                foreach (DataRow fila in dtCarrito.Rows)
                {
                    dtSQL.Rows.Add(fila["idProducto"], fila["Cantidad"], fila["Costo"]);
                }

                int idGenerado = nCompra.GuardarCompra(c, dtSQL);
                MessageBox.Show("Compra #" + idGenerado + " registrada con éxito.");

                DesactivarControles();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesactivarControles();
            LimpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaCompra consulta = new ConsultaCompra();
            consulta.Show();
            this.Close();
        }
    }
}