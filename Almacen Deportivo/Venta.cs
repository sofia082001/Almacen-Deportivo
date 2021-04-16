using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen_Deportivo
{
    class Venta
    {
        private List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
        private List<Producto> productosDisponibles = new List<Producto>();
        private List<Kit> kits = new List<Kit>();
        private Cliente clienteVenta;
        private float iva, descuento;
        private double total;
        private DateTime fechaVenta;

        public Venta(Cliente clienteVenta)
        {
            this.clienteVenta = clienteVenta;
            iva = 0.19f;
            descuento = 0.05f;
            total = 0;
            fechaVenta = DateTime.Now;          
        }

        public float Iva { get => iva; }
        public float Descuento { get => descuento; }
        public double Total { get => total; }
        public DateTime FechaVenta { get => fechaVenta; }
        internal Cliente ClienteVenta { get => clienteVenta; }

        public void GenerarFactura() 
        {
            
        }
        public void ActualizarStock() 
        {

        }
        public void VenderProducto() 
        {

        }
    }
}
