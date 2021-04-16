using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen_Deportivo
{
    class Proveedor
    {
        public enum proveedor { A, AAA, otro };
        private proveedor tipoProveedor;
        private string nombreProveedor;

        public Proveedor(proveedor tipoProveedor)
        {
            this.TipoProveedor = tipoProveedor;
            switch(tipoProveedor) //revisar no se si sea necesario hace eso
            {
                case proveedor.A:
                    {
                        NombreProveedor = "Pepito Castaño";
                        break;
                    }
                case proveedor.AAA:
                    {
                        NombreProveedor = "Carlitos Montoya";
                        break;
                    }
                case proveedor.otro:
                    {
                        NombreProveedor = "Juan Jimenez";
                        break;
                    }
            }
        }

        internal proveedor TipoProveedor { get => tipoProveedor; set => tipoProveedor = value; }
        public string NombreProveedor { get => nombreProveedor;}

        public virtual void AplicarRecargos()
        {

        }
        public virtual void AplicarDescuentos()
        {

        }

    }
}
