using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ClienteCN
    {
        private ClienteDAO objDatos = new ClienteDAO();

        public DataSet ObtenerClientes()
        {
            return objDatos.ListarClientes();
        }

        public void NuevoCliente(Cliente cliente)
        {
            objDatos.InsertarCliente(cliente);
        }

        public DataSet SugerirID()
        {
            return objDatos.ObtenerSiguienteID();
        }
    }
}