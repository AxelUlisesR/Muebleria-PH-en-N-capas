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
    public class ClienteDAO
    {
        private Conexion objConecta = new Conexion();
        private SqlConnection conec;
        private SqlDataAdapter adaptador;

        public DataSet ListarClientes()
        {
            try
            {
                using (DataSet data = new DataSet())
                {
                    conec = objConecta.Conecta();
                    adaptador = new SqlDataAdapter("consultarClientes", conec);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(data, "CLIENTES");

                    adaptador.Dispose();
                    conec.Close();
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar clientes: " + e.Message);
            }
        }

        public void InsertarCliente(Cliente obj)
        {
            try
            {
                conec = objConecta.Conecta();
                SqlCommand cmd = new SqlCommand("insertarCliente", conec);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                cmd.Parameters.AddWithValue("@RFC", obj.RFC);

                conec.Open();
                cmd.ExecuteNonQuery();
                conec.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar cliente: " + e.Message);
            }
        }

        public DataSet ObtenerSiguienteID()
        {
            try
            {
                using (DataSet data = new DataSet())
                {
                    conec = objConecta.Conecta();
                    adaptador = new SqlDataAdapter("siguienteIDCliente", conec);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                    adaptador.Fill(data, "NEXT_ID");

                    adaptador.Dispose();
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