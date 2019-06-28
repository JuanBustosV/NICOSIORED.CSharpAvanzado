using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 13 --- Stack , Queue genéricos";

            Stack<CPunto> pilaPuntos = new Stack<CPunto>();
            pilaPuntos.Push(new CPunto(3, 4));
            pilaPuntos.Push(new CPunto(5, 7));
            pilaPuntos.Push(new CPunto(9, 11));
            pilaPuntos.Push(new CPunto(1, 4));

            foreach(CPunto p in pilaPuntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("---------------");

            // Hacemos un peek
            Console.WriteLine("Peek {0}\n", pilaPuntos.Peek());

            foreach (CPunto p in pilaPuntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("---------------");

            // Hacemos dos Pop (saca elemento de la pila)
            Console.WriteLine("Pop {0}", pilaPuntos.Pop());
            Console.WriteLine("Pop {0}\n", pilaPuntos.Pop());

            foreach (CPunto p in pilaPuntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("---------------");

            // Hacemos un peek
            Console.WriteLine("Peek {0}\n", pilaPuntos.Peek());

            foreach (CPunto p in pilaPuntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("---------------");
        }
    }
}
