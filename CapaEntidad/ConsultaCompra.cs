using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ConsultaCompra
    {
        private string fecha, proveedor, direccion, telefono;
        private int idProveedor;
        private double total;

        public string Fecha { 
            get { return fecha; }
            set { fecha = value; }
        }
        public string Proveedor { 
            get { return proveedor; } 
            set { proveedor = value; }
        }
        public string Direccion {
            get { return direccion; } 
            set { direccion = value; } 
        }
        public string Telefono { 
            get { return telefono; } 
            set { telefono = value; }
        }
        public int IdProveedor { 
            get { return idProveedor; } 
            set { idProveedor = value; } 
        }
        public double Total { 
            get { return total; } 
            set { total = value; } 
        }
    }
}
