using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen_Deportivo
{
    class Producto
    {
        private double precioVenta;
        private int codigoInterno;
        private string nombreProducto;

        public Producto(string nombreProducto)
        {
            precioVenta = 0;
            for (int i = 0; i <= 10; i++) {
                Random random = new Random();
                int indice = 1000000000;
                int producto = random.Next(0, 10);
                indice *= producto;
                codigoInterno += indice;
                indice /= producto;
                indice /= 10;
                if (codigoInterno < 0) codigoInterno *= -1;
            }
            this.nombreProducto = nombreProducto;
        }

        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int CodigoInterno { get => codigoInterno; }
        public string NombreProducto { get => nombreProducto; }
    }
}
