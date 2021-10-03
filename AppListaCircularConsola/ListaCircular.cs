using System;
using System.Collections.Generic;
using System.Text;

namespace AppListaCircularConsola
{
    class ListaCircular
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }

        public ListaCircular()
        {
            head = null;
        }
        public void Agregar(Nodo n)
        {
            Nodo h = head;
            if (head == null)
            { head = n; head.Siguiente = n; return; }
            if (n.Numero < head.Numero)
            {
                n.Siguiente = head;
                //recorrer la lista y buscar el ultimo nodo
                while (h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = n;
                //al encntrarlo hacer que el sig de esa lista sea nodo sea n
                head = n;
                return;
            }
            // insertar en medio al final 
            while (h.Siguiente != head)
            {
                if(n.Numero < h.Siguiente.Numero)
                {
                    break;
                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;
        }
        public void Eliminar(int d)
        {
            if (head == null)
            {
                return;
            }
            Nodo h = head;
            if (head.Numero == d)
            {
                if(head.Siguiente == head)
                {
                    head = null;
                    return;
                }
                while (h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = Head.Siguiente;
                head = head.Siguiente;
                //hacer que el ultimo lo apunte
                return;
            }
            while (h.Siguiente != head)
            {
                if (h.Siguiente.Numero == d)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != head)
            {
                h.Siguiente = h.Siguiente.Siguiente;
            }
        }

        public override string ToString()
        {
            string lista = " Nodos: ";
            Nodo h = head;
            if(head == null)
            {
                return lista;
            }
            while(h.Siguiente != head)
            {
                lista += h.Numero + " " + h.Nombre + " ";
                h = h.Siguiente;
            }

            return lista; 
        }
    }
}
