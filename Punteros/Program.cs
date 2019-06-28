using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punteros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 26 --- Apuntadores/Punteros";

            // Punteros (apuntadores)
            // Es necesario poner el proyecto en unsafe, propiedades, compilación, y marcar: ejecutar codigo no seguro.
            unsafe
            {
                int valor = 5;

                // Creo el puntero
                int* p; // * puntero a

                // Hago que apunte a la direccion de valor
                p = &valor; // & dirección de

                Console.WriteLine("*p: {0}", *p);

                // Cambiamos el valor
                *p = 67;
                Console.WriteLine("----------------------\n*p: {0}", *p);
                Console.WriteLine("valor: {0}", valor);
            }

            // Aquí codigo fuera de unsafe
            Console.WriteLine("--- Haremos un swap ---");

            int a = 3;
            int b = 8;

            Console.WriteLine("a={0}, b={1}", a, b);

            // Invocamos el metodo que usa punteros
            unsafe { swap(&a, &b); }

            Console.WriteLine("a={0}, b={1}", a, b);
        }

        // Creacion de un metodo que usa apuntadores
        unsafe public static void swap(int* n, int* m)
        {
            int temp = *m;
            *m = *n;
            *n = temp;
        }
    }
}
