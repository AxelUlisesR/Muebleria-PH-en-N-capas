using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        private int idProducto, idCategoria, stock;
        private string nombre, descripcion;
        private double precio, costo;

        public int IdProducto {
            get { return idProducto; } 
            set { idProducto = value; } 
        }
        public int IdCategoria { 
            get { return idCategoria; } 
            set { idCategoria = value; } 
        }
        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; } }
        public string Descripcion { get 
            { return descripcion; }
            set { descripcion = value; } }
        public double Precio { 
            get { return precio; } 
            set { precio = value; }
        }
        public int Stock { 
            get { return stock; } 
            set { stock = value; } 
        }
        public double Costo { 
            get { return costo; } 
            set { costo = value; } 
        }
    }
}