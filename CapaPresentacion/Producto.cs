using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Producto : Form
    {
        private ProductoCN negocio = new ProductoCN();

        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            cboCategoria.Text = "";
            try
            {
                DataSet dsCat = negocio.ObtenerCategorias();
                cboCategoria.DataSource = dsCat.Tables["CATEGORIAS"];
                cboCategoria.DisplayMember = "concepto";   
                cboCategoria.ValueMember = "idCategoria"; 

                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar: " + ex.Message);
            }
            cboCategoria.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            dgvProductos.DataSource = negocio.ObtenerProductos().Tables["PRODUCTOS"];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled=true;
            btnNuevo.Enabled=false;
            try
            {
                LimpiarControles();
                DataSet dsID = negocio.SugerirID();
                idtxt.Text = dsID.Tables["NEXT_ID"].Rows[0]["ProximoID"].ToString();
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidad.Producto nuevoProd = new CapaEntidad.Producto
                {
                    IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text, // Captura de la descripción
                    Precio = double.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text),
                    Costo = double.Parse(txtCosto.Text)
                };

                negocio.NuevoProducto(nuevoProd);
                MessageBox.Show("Producto registrado correctamente");

                CargarGrid();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCosto.Clear();
           txtDescripcion.Clear();
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}