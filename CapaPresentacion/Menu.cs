using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Show();
            this.Hide();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Show();
            this.Hide();
        }

        private void repartidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repartidor repartidor = new Repartidor();
            repartidor.Show();
            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden venta = new Orden();
            venta.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraProveedor compra = new CompraProveedor();
            compra.Show();
            this.Hide();
        }
    }
}
