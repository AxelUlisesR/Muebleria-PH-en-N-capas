using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class VendedorCN
    {
        private VendedorDAO objDatos = new VendedorDAO();

        public DataSet ObtenerVendedores()
        {
            return objDatos.ListarVendedores();
        }

        public void NuevoVendedor(Vendedor vendedor)
        {
            objDatos.Insertar(vendedor);
        }

        public DataSet SugerirID()
        {
            return objDatos.ObtenerSiguienteID();
        }
    }
}