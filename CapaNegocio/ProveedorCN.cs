using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ProveedorCN
    {
        private ProveedorDAO objDatos = new ProveedorDAO();

        public DataSet ObtenerProveedores()
        {
            return objDatos.ListarProveedores();
        }

        public void NuevoProveedor(CapaEntidad.Proveedor proveedor)
        {
            objDatos.InsertarProveedor(proveedor);
        }

        public DataSet SugerirID()
        {
            return objDatos.ObtenerSiguienteID();
        }
    }
}