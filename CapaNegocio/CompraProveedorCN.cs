using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CompraProveedorCN
    {
        private CompraProveedorDAO objD = new CompraProveedorDAO();
        public DataTable CargarCombo(string sp) => objD.ListarCombo(sp);
        public DataTable FiltrarProductos(int id) => objD.ListarProductos(id);
        public int SiguienteID() => objD.ObtenerSiguienteID();
        public int GuardarCompra(CapaEntidad.CompraProveedor obj, DataTable detalle) => objD.RegistrarCompra(obj, detalle);
    }
}
