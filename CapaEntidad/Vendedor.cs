using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Vendedor
    {
        private int idVendedor;
        private string nombre, telefono;
        private double porcentajeComision;

        public int IdVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
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

        public double PorcentajeComision 
        {
            get { return porcentajeComision; }
            set { porcentajeComision = value; }
        }
    }
}