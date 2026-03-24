using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaEntidad;
using CapaNegocio;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Repartidor : Form
    {
        private RepartidorCN negocio = new RepartidorCN();
        public Repartidor()
        {
            InitializeComponent();
        }   
        private void Repartidor_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgvRepartidores.DataSource = negocio.ObtenerRepartidores().Tables["REPARTIDORES"];
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtNombre.Clear();
            txtTel.Clear();
            DataSet ds = negocio.SugerirID();
            idtxt.Text = ds.Tables["NEXT_ID"].Rows[0]["ProximoID"].ToString();
            txtNombre.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            try {                
                CapaEntidad.Repartidor r = new CapaEntidad.Repartidor
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTel.Text
                };
                negocio.NuevoRepartidor(r);
                MessageBox.Show("Repartidor guardado correctamente");
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
            idtxt.Clear();
            txtNombre.Clear();
            txtTel.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
