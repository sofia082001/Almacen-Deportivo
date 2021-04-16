using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen_Deportivo
{
    class ProductoComprado
    {
        private int cantidad;
        private double precioCompra;
        private float descuento;
        private float recargo;      
        private Producto producto;

        public ProductoComprado(int cantidad, Producto producto)
        {           
            this.cantidad = cantidad;
            this.producto = producto;
            precioCompra = 0;
            descuento = 0;
            recargo = 0;
        }

        public int Cantidad { get => cantidad; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public float Descuento { get => descuento; }
        public float Recargo { get => recargo; set => recargo = value; }

    }
}
