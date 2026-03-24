using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ProductoCN
    {
        private ProductoDAO objDatos = new ProductoDAO();

        public DataSet ObtenerProductos()
        {
            return objDatos.ListarProductos();
        }

        public void NuevoProducto(CapaEntidad.Producto producto)
        {
            objDatos.Insertar(producto);
        }

        public DataSet SugerirID()
        {
            return objDatos.ObtenerSiguienteID();
        }
        public DataSet ObtenerCategorias()
        {
            return objDatos.ListarCategorias();
        }
    }
}