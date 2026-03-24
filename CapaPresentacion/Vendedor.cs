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
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Vendedor : Form
    {
        private VendedorCN negocio = new VendedorCN();
        public Vendedor()
        {
            InitializeComponent();
        }

        private void Vendedor_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void CargarGrid()
        {
            dgvVendedores.DataSource = negocio.ObtenerVendedores().Tables["VENDEDORES"];
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled=true;
            btnNuevo.Enabled = false;
            txtNombre.Clear();
            txtTel.Clear();
            txtComision.Clear();
            DataSet ds = negocio.SugerirID();
            idtxt.Text = ds.Tables["NEXT_ID"].Rows[0]["ProximoID"].ToString();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnNuevo.Enabled=true;
            try
            {
                CapaEntidad.Vendedor v = new CapaEntidad.Vendedor
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTel.Text,
                    PorcentajeComision = double.Parse(txtComision.Text)
                };
                negocio.NuevoVendedor(v);
                MessageBox.Show("Vendedor guardado correctamente");
                CargarGrid();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrese de ingresar un número válido en comisión. " + ex.Message);
            }
        }
        private void LimpiarControles()
        {
            idtxt.Clear();
            txtNombre.Clear();
            txtTel.Clear();
            txtComision.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
