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
    public class ConsultaOrdenCN
    {
        private OrdenDAO objD = new OrdenDAO();

        public ConsultaOrden ObtenerCabecera(int id) => objD.BuscarCabecera(id);
        public DataTable ObtenerDetalle(int id) => objD.BuscarDetalle(id);
    }
}
