using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CapaNegocio;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ConsultaGeneralVentas : Form
    {
        public ConsultaGeneralVentaCN nReporte = new ConsultaGeneralVentaCN();
        public ConsultaGeneralVentas()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpFecha.Value.Date;
                DateTime fechaFin = dtpFechaLimite.Value.Date;

                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.");
                    return;
                }

                dgvReporte.DataSource = nReporte.ObtenerReporteVentas(fechaInicio, fechaFin);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message);
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
