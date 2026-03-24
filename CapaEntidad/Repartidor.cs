using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Repartidor
    {
        private int idRepartidor;
        private string nombre, telefono, direccion, correo;
        public int IdRepartidor
        {
            get { return idRepartidor; }
            set { idRepartidor = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
      
    }
}
