using System;
using System.Collections.Generic;
using System.IO;

namespace Almacen_Deportivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Compra> comprita = new List<Compra>();
            List<ProductoComprado> productocomprado = new List<ProductoComprado>();
            
            Producto p1 = new Producto("balon");
            //prueba de iniciar compra
            
            Compra compra1 = new Compra();

            compra1.IniciarCompra(5, p1, 1, true);
            

            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("D:\\ProductosAlmacenDeportivo\\Productos.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}
