using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        private int idCliente;
        private string nombre,telefono, direccion,correo, rfc;
        public int IdCliente {
            get { return idCliente; }
            set {idCliente= value; } }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Telefono {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion {
            get {return direccion; }
            set { direccion = value; }
        }
        public string Correo { 
            get { return correo; }
            set { correo = value; } }
        public string RFC {
            get { return rfc; }
            set { rfc = value; } 
        }
    }
}
   
