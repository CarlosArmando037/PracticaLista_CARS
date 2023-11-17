using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaLista_CARS.Clases
{
    public class ListaEnlazadas
    {
        Nodo primero;
        Nodo ultimo;

        public ListaEnlazadas()
        {
            primero = ultimo = null;
        }

        //identificar si la lista esta vacia o no
        public bool IdentificarVacio()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }
        //comprobar el estado de la lista
        public int estadodelista()
        {
            int contador= 0;
            //estado vacio
            if (IdentificarVacio())
            {
                return contador;
            }
            else
            {
                //estado con un valor
                if (primero!= null && primero.GetSiguiente() !=null)
                {
                    return contador+1;
                }
                else
                {

                    Nodo actual = primero;
                    while (actual.GetSiguiente() !=null)
                    {
                        contador++;
                        actual= actual.GetSiguiente();
                    }

                }
            }
            return contador;
        }
        public void imprimirlista()
        {
            if (IdentificarVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine($"los datos son_ {actual}");
                    actual = actual.GetSiguiente();
                }
                Console.WriteLine("->null");
            }
            
        }

        public void buscarelemento()
        {
            Console.WriteLine("ingresa un elemento a buscar: ");
            int valorbuscar=Convert.ToInt32(Console.ReadLine());
            bool encontrado=false;
            

            if (IdentificarVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual= primero;
                while (actual!= null)
                {
                    actual = actual.GetSiguiente();
                    if (actual.datos == valorbuscar)
                    {
                        Console.WriteLine("el dato se ha encontrado");
                        encontrado = true;
                        break;
                    }
                    else
                    {
                        actual= actual.GetSiguiente();
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encuentra");
                }
            }
        }

        public void encontrarposicion()
        {

            Console.WriteLine("ingresa un elemento a buscar: ");
            int valorbuscar = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            if (IdentificarVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                int cont = 0;
                while (actual != null)
                {
                   cont++;
                    actual = actual.GetSiguiente();
                    if (actual.datos == valorbuscar)
                    {
                        Console.WriteLine("esta en la posicion:" + cont);
                        encontrado = true;
                        break;
                    }
                    else
                    {
                        actual = actual.GetSiguiente();
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encuentra");
                }
            }
        }

    }
}
