using System;
using System.Collections;//.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 9 --- Stack";
            // Ver documentación, seleccionar clase y pulsar F1
            Stack pila = new Stack(); // LIFO

            // Agregamos elementos (pueden ser de cualquier tipo, mezclados)
            pila.Push("Manzana");
            pila.Push("Pera");
            pila.Push("Ciruela");
            pila.Push("Mango");

            // Iteramos el stack
            foreach (string fruta in pila)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("-----");

            // Hacemos pop (posible type cast), saca elemento de la pila
            Console.WriteLine("Pop: {0}", pila.Pop());

            foreach (string fruta in pila)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("-----");

            // Hacemos peek, no saca el elemento
            Console.WriteLine("Peek: {0}", pila.Peek());

            foreach (string fruta in pila)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("-----");

            // Cantidad de elementos
            Console.WriteLine("Elementos: {0}", pila.Count);

            Console.WriteLine("-----");
        }
    }
}
