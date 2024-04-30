using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Cola
    {
        public Nodo inicio;
        public Nodo fin;

        public Cola()
        {
            inicio = null;
            fin = null;
        }

        public void insertar(Nodo archivo)
        {
            if(inicio == null)
            {
                inicio = archivo;
                fin = archivo;
            }
            else
            {
                fin.siguiente = archivo;
                fin = archivo;
            }
        }

        public void listar(ListBox lista)
        {
            lista.Items.Clear();

            if (inicio == null) lista.Items.Add("Cola vacia");
            else
            {
                Nodo actual = inicio;

                while(actual != null)
                {
                    lista.Items.Add(actual.nombreArchivo);
                    actual = actual.siguiente;
                }
            }
        }

        public void eliminar()
        {
            if(inicio != null)
            {
                Nodo aux = inicio;
                inicio = aux.siguiente;
                aux = null;

                if (inicio == null) fin = null;
            }
        }
    }
}
