using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class OrdenCN
    {
        private OrdenDAO objD = new OrdenDAO();
        public DataTable CargarCombo(string sp) => objD.ListarCombo(sp);
        public DataTable FiltrarProductos(int id) => objD.ListarProductos(id);
        public int RegistrarOrden(Orden o, DataTable detalle)
        {
            return objD.EjecutarOrden(o, detalle);
        }
        public int ConsultarSiguienteID()
        {
            return objD.ObtenerSiguienteID();
        }
    }
}
