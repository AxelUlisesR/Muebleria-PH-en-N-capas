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
    public class RepartidorDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;

        public DataSet ListarRepartidores()
        {
            try
            {
                using (DataSet data = new DataSet())
                {
                    conec = objConecta.Conecta();
                    adaptador = new SqlDataAdapter("consultarRepartidores", conec);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(data, "REPARTIDORES");
                    adaptador.Dispose();
                    conec.Close();
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar repartidores: " + e.Message);
            }
        }

        public void Insertar(Repartidor obj)
        {
            try
            {
                conec = objConecta.Conecta();
                SqlCommand cmd = new SqlCommand("insertarRepartidor", conec);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                conec.Open();
                cmd.ExecuteNonQuery();
                conec.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar repartidor: " + e.Message);
            }
        }
        public DataSet ObtenerSiguienteID()
        {
            try
            {
                using (DataSet data = new DataSet())
                {
                    conec = objConecta.Conecta();
                    adaptador = new SqlDataAdapter("siguienteIDRepartidor", conec);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(data, "NEXT_ID");
                    conec.Close();
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener siguiente ID: " + e.Message);
            }
        }

    }
}