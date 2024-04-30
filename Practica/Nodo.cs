using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Nodo
    {
        public string nombreArchivo;
        public string prioridad;

        public Nodo siguiente;

        public Nodo(string nombreArchivo, string prioridad)
        {
            this.nombreArchivo = nombreArchivo;
            this.prioridad = prioridad;

            this.siguiente = null;
        }
    }
}
