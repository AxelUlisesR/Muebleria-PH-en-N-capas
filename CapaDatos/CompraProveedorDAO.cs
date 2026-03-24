using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CompraProveedorDAO
    {
        private Conexion objCon = new Conexion();

        public int RegistrarCompra(CompraProveedor obj, DataTable detalle)
        {
            int idGenerado = 0;
            using (SqlConnection con = objCon.Conecta())
            {
                SqlCommand cmd = new SqlCommand("RegistrarCompra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", obj.IdProveedor);
                cmd.Parameters.AddWithValue("@fecha", obj.Fecha);
                cmd.Parameters.AddWithValue("@total", obj.Total);
                SqlParameter paramDetalle = cmd.Parameters.AddWithValue("@Detalle", detalle);
                paramDetalle.SqlDbType = SqlDbType.Structured;
                paramDetalle.TypeName = "DETALLE_COMPRA_TIPO";

                con.Open();
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return idGenerado;
        }

        public int ObtenerSiguienteID()
        {
            using (SqlConnection con = objCon.Conecta())
            {
                SqlCommand cmd = new SqlCommand("SiguienteIDCompra", con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public DataTable ListarCombo(string sp)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sp, objCon.Conecta());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListarProductos(int idCat)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("CargarProductosPorCat", objCon.Conecta());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCat", idCat);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public ConsultaCompra ObtenerCabecera(int id)
        {
            ConsultaCompra ent = null;
            using (SqlConnection con = objCon.Conecta())
            {
                SqlCommand cmd = new SqlCommand("ConsultarCompra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ent = new ConsultaCompra
                    {
                        Fecha = Convert.ToDateTime(dr["fecha"]).ToShortDateString(),
                        Total = Convert.ToDouble(dr["total"]),
                        IdProveedor = Convert.ToInt32(dr["idProveedor"]),
                        Proveedor = dr["Proveedor"].ToString(),
                        Direccion = dr["direccion"].ToString(),
                        Telefono = dr["telefono"].ToString()
                    };
                }
            }
            return ent;
        }

        public DataTable ObtenerDetalle(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("ConsultarCompraDetalle", objCon.Conecta());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@idCompra", id);
            da.Fill(dt);
            return dt;
        }
    }
}

