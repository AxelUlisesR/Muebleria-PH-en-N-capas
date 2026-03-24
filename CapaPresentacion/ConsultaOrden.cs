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
    public partial class ConsultaOrden : Form
    {
        private ConsultaOrdenCN nConsulta = new ConsultaOrdenCN();
        public ConsultaOrden()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxt.Text);
            var cabecera = nConsulta.ObtenerCabecera(id);

            if (cabecera != null)
            {
                
                dtpFecha.Text = cabecera.FechaPedido;
                dtpEntrega.Text = cabecera.FechaEntrega;
                txtEstado.Text = cabecera.Estado;

            
                txtCliente.Text = cabecera.Cliente;
                txtDirCliente.Text = cabecera.Direccion;
                txtTelCliente.Text = cabecera.TelCliente;
                txtRFCCliente.Text = cabecera.RFC;
                txtCorreoCliente.Text = cabecera.Correo;

                
                txtVendedor.Text = cabecera.Vendedor;
                txtTelVendedor.Text = cabecera.TelVendedor;
                txtComisionVendedor.Text = cabecera.Comision.ToString() + "%";

               
                txtRepartidor.Text = cabecera.Repartidor;
                txtTelRepartidor.Text = cabecera.TelRepartidor;

                
                double sub = cabecera.Total / 1.16;
                txtSubtotal.Text = sub.ToString("N2");
                txtIVA.Text = (cabecera.Total - sub).ToString("N2");
                txtTotal.Text = cabecera.Total.ToString("N2");

               
                dgvDetalle.DataSource = nConsulta.ObtenerDetalle(id);
            }
            else
            {
                MessageBox.Show("La orden no existe.");
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
