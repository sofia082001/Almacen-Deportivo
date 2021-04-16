using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen_Deportivo
{
    class ProductoVendido
    {
        private double precioVenta;
        private List<Producto> productos = new List<Producto>();
        Producto producto;
        private int cantidad;

        public ProductoVendido(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public double PrecioVenta { get => precioVenta; }
        internal Producto Producto { get => producto; }
        public int Cantidad { get => cantidad; }

        


    }
}
