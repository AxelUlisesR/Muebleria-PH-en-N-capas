using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ConsultaOrden
    {
        private string fechaPedido, fechaEntrega;
        private double total;
        private string cliente, direccion, telCliente, rfc, correo;
        private string vendedor, telVendedor, estado;
        private double comision;
        private string repartidor, telRepartidor;

        public string FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; }
        }
        public string FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string TelCliente
        {
            get { return telCliente; }
            set { telCliente = value; }
        }
        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }
        public string TelVendedor
        {
            get { return telVendedor; }
            set { telVendedor = value; }
        }
        public double Comision
        {
            get { return comision; }
            set { comision = value; }
        }
        public string Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }
        public string TelRepartidor
        {
            get { return telRepartidor; }
            set { telRepartidor = value; }
        }
    }
}

