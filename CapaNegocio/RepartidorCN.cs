using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class RepartidorCN
    {
        private RepartidorDAO objDatos = new RepartidorDAO();

        public DataSet ObtenerRepartidores()
        {
            return objDatos.ListarRepartidores();
        }

        public void NuevoRepartidor(Repartidor repartidor)
        {
            objDatos.Insertar(repartidor);
        }

        public DataSet SugerirID()
        {
            return objDatos.ObtenerSiguienteID();
        }
    }
}
