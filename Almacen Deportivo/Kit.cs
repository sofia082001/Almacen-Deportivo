using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen_Deportivo
{
    class Kit : Producto
    {      
        private List<Producto> kits = new List<Producto>();
        public Kit(string nombreProducto) : base(nombreProducto)
        {

        }

        
    }
}
