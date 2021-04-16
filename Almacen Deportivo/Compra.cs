using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Almacen_Deportivo
{
    class Compra
    {
        private DateTime fechaCompra;
        private double total;
        private double mayorPrecioCompras;

        private List<ProductoComprado> productosComprados = new List<ProductoComprado>();
        private List<Kit> kits = new List<Kit>();
        private string rutaFactura = @" D:\UPB\2021-1\Programación Orientada a Objetos\1\1\myList.txt";//ruta del archio de texto(falta ponerla)

        public Compra()
        {
            fechaCompra = DateTime.Now;
            total = 0;
            mayorPrecioCompras = 0;
        }

        public DateTime FechaCompra { get => fechaCompra; }
        public double Total { get => total; }
        public double MayorPrecioCompras { get => mayorPrecioCompras; }

        public void GenerarFactura()
        {
            using (StreamWriter mylogs = File.AppendText(rutaFactura)) {
                foreach(var item in productosComprados) {
                    //mylogs.WriteLine(item.Cantidad + " " + item.productos.NombreProducto);//no me salen los errores, por lo tanto no se las soluciones xd
                }
                mylogs.WriteLine("Costo total: " + total);
                mylogs.Close();
            }
        }

        public void IniciarCompra(int cantidad, Producto producto, int proveedor, bool procedencia)//productoComprado //corregir
        {
            //se elige el provedor
            //1) tengo que elegir si nacional o internacional bool true-nacional false-importado
            //2) tengo que elegir proveedor como lo elijo? //1) A 2) AAA 3) otro 
                        
            switch(procedencia)
            {
                case true:
                    switch (proveedor)
                    {
                        case 1:
                            productosComprados.Add(new ProductoComprado(cantidad, producto));
                            
                            break;
                        case 2:
                            productosComprados.Add(new Nacional(cantidad, producto, ProductoComprado.proveedor.AAA));
                            break;
                        case 3:
                            productosComprados.Add(new Nacional(cantidad, producto, ProductoComprado.proveedor.otro));
                            break;
                    }                    
                    break;

                case false:
                    switch (proveedor)
                    {
                        case 1:
                            productosComprados.Add(new Importado(cantidad, producto, ProductoComprado.proveedor.A));
                            break;
                        case 2:
                            productosComprados.Add(new Importado(cantidad, producto, ProductoComprado.proveedor.AAA));
                            break;
                        case 3:
                            productosComprados.Add(new Importado(cantidad, producto, ProductoComprado.proveedor.otro));
                            break;
                    }
                    break;

            } 

            
        }

        public void EscogerProductos()
        {
            //pues elige el producto


        }
        public void TasadeCambio()
        {
            /* double tmr = 3658.22;
             * if (proveedor = false)
             * {
             *      precioProducto = precioProducto*tmr;
             * }
             */
        }
        public void FinalizarCompra(int proveedor) //holi 
        {
            /*float recargo, descuento;
             * if(proveedor = false) recargo = 0.014;
             *      if(proveedor == 2) descuento = 0.03;
             *      else descuento = 0;
             *      precioTotalProd= (precioProducto-(precios*descuento))*cantidad;
             *      precioTotalInt = Sum precioTotalProd *+ cada producto, idk
             * else {
             * if(proveedor == 1)recargo = 0.01; //nacional
             * else recargo = 0.02;
             * if(proveedor == 2 && cantidadComprada > 200) descuento = 0.03; 
             * else descuento = 0;
             * precioTotalProd= (precioProducto-(precios*descuento))*cantidad;
             * precioTotalNal = Sum precioTotalProd * cada producto, idk
            ------------------TOTAL------------------------
            double total;
            total = precioTotalInt + precioTotalNal;

            ***FALTA EL IVA AAAAA***ç   precioiv = precio¿*19%  precioTotal+precioiv
            to do: - acceder a los productos que escogió, sus cantidades y precios. - aplicar IVA
                   - Sumar productos con los nuevos precios = total.
             How to do: .*/ //XD
            //precioProducto = precio+=+precio*19%
            //pseudocódigo
        }
        public void ActualizarStock()
        {
            //se actuliza el archivo de texto cada vez que se hace una compra
        }

        
    }
}
