using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ConsultaGeneralVentaCN
    {
        ConsultaGeneralVentaDAO objD = new ConsultaGeneralVentaDAO();
        public DataTable ObtenerReporteVentas(DateTime inicio, DateTime fin)
        {
           return objD.ReporteGeneralVentas(inicio, fin);
        }
    }
}
