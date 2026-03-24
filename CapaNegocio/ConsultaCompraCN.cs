using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class ConsultaCompraCN
    {
        private CompraProveedorDAO objD = new CompraProveedorDAO();

        public ConsultaCompra ConsultarCabecera(int id) => objD.ObtenerCabecera(id);
        public DataTable ConsultarDetalle(int id) => objD.ObtenerDetalle(id);
    }
}
