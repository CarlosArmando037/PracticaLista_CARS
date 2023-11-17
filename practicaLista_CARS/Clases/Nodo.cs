using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaLista_CARS.Clases
{
    public class Nodo
    {
        private int _datos;
        private Nodo _siguiente;

        public Nodo(int valor)
        {
            _datos= valor;
            //con saber si el elemento es el ultimo, es cuando el que sigue es null
            _siguiente = null;
        }
        public Nodo(int valor, Nodo siguiente)
        {
            _datos = valor;
            _siguiente= siguiente;
        }
        public int GetDatos()
        {
            return _datos;
        }

        //estos 2 son los mismos y hacen lo mismo
        public int datos { get; set; }

        public Nodo GetSiguiente() { 
        return  _siguiente;
        }

       


    }
}
