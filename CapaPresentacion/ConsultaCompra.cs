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
    public partial class ConsultaCompra : Form
    {
        private ConsultaCompraCN nConsulta = new ConsultaCompraCN();
        public ConsultaCompra()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtxt.Text)) return;

            try
            {
                int id = int.Parse(idtxt.Text);
                CapaEntidad.ConsultaCompra cab = nConsulta.ConsultarCabecera(id);

                if (cab != null)
                {
                    dtpFecha.Text = cab.Fecha;
                    txtNombreProveedor.Text = cab.Proveedor;
                    idProveedortxt.Text = cab.IdProveedor.ToString();
                    txtTel.Text = cab.Telefono;
                    txtDir.Text = cab.Direccion;

                    double sub = cab.Total / 1.16;
                    txtSubtotal.Text = sub.ToString("N2");
                    txtIVA.Text = (cab.Total - sub).ToString("N2");
                    txtTotal.Text = cab.Total.ToString("N2");

                    dataGridView1.DataSource = nConsulta.ConsultarDetalle(id);
                }
                else
                {
                    MessageBox.Show("No se encontró la compra con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
