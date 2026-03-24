using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class ProveedorDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;

        public DataSet ListarProveedores()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("consultarProveedores", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(data, "PROVEEDORES");
                conec.Close();
                return data;
            }
        }

        public void InsertarProveedor(CapaEntidad.Proveedor obj)
        {
            using (SqlConnection con = objConecta.Conecta())
            {
                SqlCommand cmd = new SqlCommand("insertarProveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet ObtenerSiguienteID()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("siguienteIDProveedor", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(data, "NEXT_ID");
                conec.Close();
                return data;
            }
        }
    }
}