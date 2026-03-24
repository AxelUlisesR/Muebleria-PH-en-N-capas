using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Data;

namespace CapaPresentacion
{
    public partial class Cliente : Form
    {
        private ClienteCN negocio = new ClienteCN();

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
             dgvClientes.DataSource = negocio.ObtenerClientes().Tables["CLIENTES"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            try
            {
                CapaEntidad.Cliente nuevo = new CapaEntidad.Cliente
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTel.Text,
                    Direccion = txtDir.Text,
                    Correo = txtCorreo.Text,
                    RFC = txtRFC.Text
                };

                negocio.NuevoCliente(nuevo);

                MessageBox.Show("Cliente registrado correctamente");

                LimpiarControles();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtTel.Clear();
            txtDir.Clear();
            txtCorreo.Clear();
            txtRFC.Clear();
            txtNombre.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            try
            {
                LimpiarControles();
                DataSet ds = negocio.SugerirID();
                if (ds.Tables["NEXT_ID"].Rows.Count > 0)
                {
                    idtxt.Text = ds.Tables["NEXT_ID"].Rows[0]["ProximoID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();

        }
    }
}