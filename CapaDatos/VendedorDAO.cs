using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class VendedorDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;

        public DataSet ListarVendedores()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("consultarVendedores", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(data, "VENDEDORES");
                conec.Close();
                return data;
            }
        }

        public void Insertar(Vendedor obj)
        {
            using (SqlConnection con = objConecta.Conecta())
            {
                SqlCommand cmd = new SqlCommand("insertarVendedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Comision", obj.PorcentajeComision); 

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet ObtenerSiguienteID()
        {
            using (DataSet data = new DataSet())
            {
                conec = objConecta.Conecta();
                adaptador = new SqlDataAdapter("siguienteIDVendedor", conec);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(data, "NEXT_ID");
                conec.Close();
                return data;
            }
        }
    }
}