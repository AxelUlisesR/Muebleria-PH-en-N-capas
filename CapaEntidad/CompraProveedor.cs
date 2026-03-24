using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CompraProveedor
    {
        private int idCompra, idProveedor;
        private DateTime fecha;
        private double total;
        private string estado;

        public int IdCompra {
            get { return idCompra; } 
            set { idCompra = value; }
        }
        public int IdProveedor {
            get { return idProveedor; } 
            set { idProveedor = value; } 
        }
        public DateTime Fecha { 
            get { return fecha; }
            set { fecha = value; }
        }
        public double Total { 
            get { return total; } 
            set { total = value; } 
        }
        public string Estado {
            get { return estado; } 
            set { estado = value; } 
        }
    }
}
