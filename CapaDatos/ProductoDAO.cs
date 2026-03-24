using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class ProductoDAO
    {
        private Conexion objConecta = new Conexion();

        public DataSet ListarProductos()
        {
            using (DataSet data = new DataSet())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("consultarProductos", objConecta.Conecta());
                adaptador.Fill(data, "PRODUCTOS");
                return data;
            }
        }

        public DataSet ListarCategorias()
        {
            using (DataSet data = new DataSet())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("consultarCategorias", objConecta.Conecta());
                adaptador.Fill(data, "CATEGORIAS");
                return data;
            }
        }

        public void Insertar(Producto obj)
        {
            using (SqlConnection con = objConecta.Conecta())
            {
                SqlCommand cmd = new SqlCommand("insertarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCat", obj.IdCategoria);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", obj.Precio);
                cmd.Parameters.AddWithValue("@Stock", obj.Stock);
                cmd.Parameters.AddWithValue("@Costo", obj.Costo);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet ObtenerSiguienteID()
        {
            using (DataSet data = new DataSet())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("siguienteIDProducto", objConecta.Conecta());
                adaptador.Fill(data, "NEXT_ID");
                return data;
            }
        }
    }
}