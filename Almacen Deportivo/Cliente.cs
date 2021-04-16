using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen_Deportivo
{
    class Cliente
    {
        private string nombre;
        private string correo;

        public Cliente(string nombre, string correo)
        {
            this.nombre = nombre;
            this.correo = correo;
        }

        public string Nombre { get => nombre; }
        public string Correo { get => correo; }
    }
}
