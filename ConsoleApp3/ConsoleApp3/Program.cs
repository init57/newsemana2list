using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public class Crud
        {
            public Nodo cabeza = null;
            public Nodo listasa()
            {
                Nodo listen = cabeza;
                return listen;
            }
            public void insertar_inicio(int valor)
            {

                Nodo nuevo = new Nodo();
                nuevo.dato = valor;
                nuevo.siguiente = cabeza;
                cabeza = nuevo;
            }
            public void mostrar()
            {
                Nodo temporal = cabeza;
                while (temporal != null)
                {
                    Console.WriteLine(temporal.dato + "\t");
                    temporal = temporal.siguiente;
                }
            }
            public void actualizar(int v_actual, int v_nuevo)
            {
                Nodo temporal = cabeza;
                while (temporal != null)
                {
                    if (temporal.dato == v_actual)
                    {
                        temporal.dato = v_nuevo;
                        break;
                    }
                    temporal = temporal.siguiente;
                }
            }
            public void burbuja()
            {
                Nodo temp1 = cabeza;
                Nodo temp2 = cabeza;
                while (temp1 != null)
                {
                    while (temp2.siguiente != null)
                    {
                        int v1 = temp2.dato;
                        int v2 = temp2.siguiente.dato;
                        if (v2 < v1)
                        {
                            int aux = v1;
                            v1 = v2;
                            v2 = aux;
                        }
                        temp2.dato = v1;
                        temp2.siguiente.dato = v2;
                        temp2 = temp2.siguiente;
                    }
                    temp2 = cabeza;
                    temp1 = temp1.siguiente;
                }
            }
            public void unirlistas(Nodo lista11, Nodo lista22)
            {
                Nodo temp1 = lista11;
                while (temp1.siguiente != null)
                {
                    temp1 = temp1.siguiente;
                }
                temp1.siguiente = lista22;

                lista22 = null;

                cabeza = lista11;
            }
        }

        static void Main(string[] args)
        {

            int valoractualizar, valorreemplazar;
            Console.WriteLine("lista con metodo insercion al inicio\t");
            Crud lista = new Crud();
            lista.insertar_inicio(12);
            lista.insertar_inicio(13);
            lista.insertar_inicio(14);
            lista.insertar_inicio(15);
            lista.insertar_inicio(16);
            lista.mostrar();

            Console.WriteLine("ingrese dato actualizar\t");
            valoractualizar = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese dato a reemplazar\t");
            valorreemplazar = int.Parse(Console.ReadLine());
            Console.WriteLine("nueva lista\t");
            lista.actualizar(valoractualizar, valorreemplazar);
            lista.mostrar();
            Console.WriteLine("lista ordenada burbuja \t");
            lista.burbuja();
            lista.mostrar();

            Console.WriteLine("Nueva Lista 2 \t");
            Crud lista2 = new Crud();
            lista2.insertar_inicio(12);
            lista2.insertar_inicio(30);
            lista2.insertar_inicio(10);
            lista2.insertar_inicio(2);

            lista2.mostrar();

            Crud lista3 = new Crud();
            lista3.unirlistas(lista.listasa(),lista2.listasa());

            Console.WriteLine("Nueva Lista 3 \t");
            lista3.mostrar();
            Console.ReadKey();
        }
    }
}
