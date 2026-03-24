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
    public partial class Proveedor : Form
    {  
        private ProveedorCN negocio = new ProveedorCN();
        public Proveedor()
        {
            InitializeComponent();
        }
      

        private void Proveedor_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvProveedores.DataSource = negocio.ObtenerProveedores().Tables["PROVEEDORES"];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled=false;
            txtNombre.Clear();
            txtTel.Clear();
            txtDir.Clear();

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
                CapaEntidad.Proveedor p = new CapaEntidad.Proveedor
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTel.Text,
                    Direccion = txtDir.Text
                };

                negocio.NuevoProveedor(p);
                MessageBox.Show("Proveedor guardado exitosamente");
                CargarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
