using System;

namespace CapaEntidad
{
    public class Orden
    {
        private int idCliente, idVendedor, idRepartidor;
        private DateTime fechaPedido, fechaEntrega;
        private double total;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public int IdVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }
        public int IdRepartidor
        {
            get { return idRepartidor; }
            set { idRepartidor = value; }
        }
        public DateTime FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; }
        }
        public DateTime FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
    }

    public class DetalleOrden
    {
        private int idProducto, cantidad;
        private double precio;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}