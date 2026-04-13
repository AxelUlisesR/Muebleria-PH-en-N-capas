using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Orden : Form
    {
        public Orden()
        {
            InitializeComponent();
        }

        private OrdenCN nOrden = new OrdenCN();
        private DataTable dtCarrito;

        private void Venta_Load(object sender, EventArgs e)
        {
            ConfigurarCarrito();
            DesactivarControles();
        }

        private void DesactivarControles()
        {
            dtpEntrega.Enabled = false;
            dtpFecha.Enabled = false;
            cboCliente.Enabled = false;
            cboVendedor.Enabled = false;
            cboRepartidor.Enabled = false;
            cboCategoria.Enabled = false;
            cboProducto.Enabled = false;
            txtCantidad.Enabled = false;
            btnOK.Enabled = false;
            btnGrabar.Enabled = false;

            cboCliente.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;
            cboRepartidor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
        }

        private void ConfigurarCarrito()
        {
            dtCarrito = new DataTable();
            dtCarrito.Columns.Add("idProducto", typeof(int));
            dtCarrito.Columns.Add("Nombre", typeof(string));
            dtCarrito.Columns.Add("Cantidad", typeof(int));
            dtCarrito.Columns.Add("Precio", typeof(double));
            dgvDetalle.DataSource = dtCarrito;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text)) return;

            int id = (int)cboProducto.SelectedValue;
            string nombre = cboProducto.Text;
            int cant = int.Parse(txtCantidad.Text);
            double prec = double.Parse(txtPrecio.Text);

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
                dtCarrito.Rows.Add(id, nombre, cant, prec);
            }

            CalcularTotales();

            cboProducto.SelectedIndex = -1;
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtDescripcion.Clear();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidad.Orden o = new CapaEntidad.Orden();
                o.IdCliente = (int)cboCliente.SelectedValue;
                o.IdVendedor = (int)cboVendedor.SelectedValue;
                o.IdRepartidor = (int)cboRepartidor.SelectedValue;
                o.FechaPedido = dtpFecha.Value;
                o.FechaEntrega = dtpEntrega.Value;
                o.Total = double.Parse(txtTotal.Text);

                DataTable dtSQL = new DataTable();
                dtSQL.Columns.Add("idProducto", typeof(int));
                dtSQL.Columns.Add("cantidad", typeof(int));
                dtSQL.Columns.Add("precio", typeof(double));

                foreach (DataRow fila in dtCarrito.Rows)
                {
                    dtSQL.Rows.Add(fila["idProducto"], fila["cantidad"], fila["precio"]);
                }

                int idGenerado = nOrden.RegistrarOrden(o, dtSQL);

                idtxt.Text = idGenerado.ToString();
                MessageBox.Show("Orden #" + idGenerado + " registrada con éxito.");

                DesactivarControles();
                LimpiarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar: " + ex.Message);
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.DataSource != null && cboCliente.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)cboCliente.SelectedItem;
                txtTelCliente.Text = row["telefono"].ToString();
                txtDirCliente.Text = row["direccion"].ToString();
                txtRFCCliente.Text = row["rfc"].ToString();
                txtCorreoCliente.Text = row["correo"].ToString();
            }
        }

        private void cboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVendedor.DataSource != null && cboVendedor.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)cboVendedor.SelectedItem;
                txtTelVendedor.Text = row["telefono"].ToString();
                txtComisionVendedor.Text = row["porcentajeComision"].ToString() + "%";
            }
        }

        private void cboRepartidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRepartidor.DataSource != null && cboRepartidor.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)cboRepartidor.SelectedItem;
                txtTelRepartidor.Text = row["telefono"].ToString();
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex != -1 && cboCategoria.SelectedItem is DataRowView)
            {
                try
                {
                    DataRowView drv = (DataRowView)cboCategoria.SelectedItem;
                    int idCat = Convert.ToInt32(drv["idCategoria"]);

                    cboProducto.DataSource = nOrden.FiltrarProductos(idCat);
                    cboProducto.DisplayMember = "nombre";
                    cboProducto.ValueMember = "idProducto";

                    cboProducto.SelectedIndex = -1;
                    txtPrecio.Clear();
                    txtStock.Clear();
                    txtDescripcion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar productos: " + ex.Message);
                }
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.DataSource != null && cboProducto.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)cboProducto.SelectedItem;
                txtPrecio.Text = row["precio"].ToString();
                txtStock.Text = row["stock"].ToString();
                txtDescripcion.Text = row["descripcion"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarTodosLosCombos();
            dtpFecha.Enabled = true;
            dtpEntrega.Enabled = true;
            cboCliente.Enabled = true;
            cboVendedor.Enabled = true;
            cboRepartidor.Enabled = true;
            cboCategoria.Enabled = true;
            cboProducto.Enabled = true;
            txtCantidad.Enabled = true;
            btnOK.Enabled = true;
            btnGrabar.Enabled = true;

            dtCarrito.Clear();
            LimpiarTextos();

            int proximoID = nOrden.ConsultarSiguienteID();
            idtxt.Text = proximoID.ToString();
        }

        private void LimpiarTextos()
        {
            idtxt.Clear();
            txtDirCliente.Clear();
            txtTelCliente.Clear();
            txtRFCCliente.Clear();
            txtCorreoCliente.Clear();
            txtComisionVendedor.Clear();
            txtDescripcion.Clear();
            txtTelVendedor.Clear();
            txtTelRepartidor.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtSubtotal.Clear();
            txtIVA.Clear();
            txtTotal.Clear();
            cboCliente.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;
            cboRepartidor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            if (dtCarrito != null)
            {
                dtCarrito.Rows.Clear();
            }
            dtpFecha.Value = DateTime.Now;
            dtpEntrega.Value = DateTime.Now;
        }
        private void CargarTodosLosCombos()
        {
            cboCliente.DataSource = nOrden.CargarCombo("CargarClientes");
            cboCliente.DisplayMember = "nombre";
            cboCliente.ValueMember = "idCliente";

            cboVendedor.DataSource = nOrden.CargarCombo("CargarVendedores");
            cboVendedor.DisplayMember = "nombre";
            cboVendedor.ValueMember = "idVendedor";

            cboRepartidor.DataSource = nOrden.CargarCombo("CargarRepartidores");
            cboRepartidor.DisplayMember = "nombre";
            cboRepartidor.ValueMember = "idRepartidor";

            cboCategoria.DataSource = nOrden.CargarCombo("CargarCategorias");
            cboCategoria.DisplayMember = "concepto";
            cboCategoria.ValueMember = "idCategoria";

            cboCliente.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;
            cboRepartidor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }

        private void CalcularTotales()
        {
            double subtotal = 0;

            foreach (DataRow fila in dtCarrito.Rows)
            {
                int cantidad = Convert.ToInt32(fila["cantidad"]);
                double precio = Convert.ToDouble(fila["precio"]);
                subtotal += (cantidad * precio);
            }

            double iva = subtotal * 0.16;
            double total = subtotal + iva;

            txtSubtotal.Text = subtotal.ToString("0.00");
            txtIVA.Text = iva.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesactivarControles();
            LimpiarTextos();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
       ConsultaOrden consultaForm = new ConsultaOrden();
            consultaForm.ShowDialog();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaGeneralVentas consultaGeneralVentas = new ConsultaGeneralVentas();
            consultaGeneralVentas.Show();
            this.Hide();
        }
    }
}