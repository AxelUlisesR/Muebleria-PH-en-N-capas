using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConsultaGeneralVentaDAO
    {
        private Conexion objCon = new Conexion();

        public DataTable ReporteGeneralVentas(DateTime inicio, DateTime fin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = objCon.Conecta())
                {
                    SqlCommand cmd = new SqlCommand("ConsultaGeneralVenta", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaInicio", inicio);
                    cmd.Parameters.AddWithValue("@fechaFinal", fin);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
