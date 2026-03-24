using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class OrdenDAO
    {
        private Conexion objCon = new Conexion();

        public int EjecutarOrden(Orden o, DataTable detalle)
        {
            int idGenerado = 0;
            using (SqlConnection con = objCon.Conecta())
            {
                SqlCommand cmd = new SqlCommand("ventaCompleta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", o.IdCliente);
                cmd.Parameters.AddWithValue("@idVendedor", o.IdVendedor);
                cmd.Parameters.AddWithValue("@idRepartidor", o.IdRepartidor);
                cmd.Parameters.AddWithValue("@fechaPedido", o.FechaPedido);
                cmd.Parameters.AddWithValue("@fechaEntrega", o.FechaEntrega);
                cmd.Parameters.AddWithValue("@total", o.Total);

                SqlParameter param = cmd.Parameters.AddWithValue("@Detalle", detalle);
                param.SqlDbType = SqlDbType.Structured;
                param.TypeName = "DETALLE_VENTA";

                con.Open();
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return idGenerado;
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
        public int ObtenerSiguienteID()
        {
            int siguiente = 0;
            using (SqlConnection con = objCon.Conecta())
            {
                SqlCommand cmd = new SqlCommand("ObtenerSiguienteIdOrden", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                siguiente = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return siguiente;
        }

        public ConsultaOrden BuscarCabecera(int id)
        {
            ConsultaOrden ent = null;
            using (SqlConnection con = objCon.Conecta())
            {
                SqlCommand cmd = new SqlCommand("ConsultarOrden", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrden", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ent = new ConsultaOrden
                    {
                        FechaPedido = dr["fechaDePedido"].ToString(),
                        FechaEntrega = dr["fechaDeEntrega"].ToString(),
                        Total = Convert.ToDouble(dr["total"]),
                        Estado = dr["estado"].ToString(),
                        Cliente = dr["Cliente"].ToString(),
                        Direccion = dr["direccion"].ToString(),
                        TelCliente = dr["TelCliente"].ToString(),
                        RFC = dr["rfc"].ToString(),
                        Correo = dr["correo"].ToString(),
                        Vendedor = dr["Vendedor"].ToString(),
                        TelVendedor = dr["TelVendedor"].ToString(),
                        Comision = Convert.ToDouble(dr["porcentajeComision"]),
                        Repartidor = dr["Repartidor"].ToString(),
                        TelRepartidor = dr["TelRepartidor"].ToString()
                    };
                }
            }
            return ent;
        }

        public DataTable BuscarDetalle(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("ConsultarOrdenDetalle", objCon.Conecta());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@idOrden", id);
            da.Fill(dt);
            return dt;
        }

    }
}
