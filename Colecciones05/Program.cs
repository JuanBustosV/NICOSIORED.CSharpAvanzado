using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 13 --- Stack , Queue genéricos";

            Queue<CPunto> colaPuntos = new Queue<CPunto>();

            colaPuntos.Enqueue(new CPunto(3, 7));
            colaPuntos.Enqueue(new CPunto(7, 9));
            colaPuntos.Enqueue(new CPunto(11, 2));

            foreach (CPunto p in colaPuntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("--------------");

            // Hacemos un peek
            Console.WriteLine(colaPuntos.Peek());

            foreach (CPunto p in colaPuntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("--------------");

            // Hacemos dequeue, lo saca de la cola
            Console.WriteLine("Dequeue {0}", colaPuntos.Dequeue());
            Console.WriteLine("Dequeue {0}", colaPuntos.Dequeue());
            //Console.WriteLine("Dequeue {0}", colaPuntos.Dequeue());

            foreach (CPunto p in colaPuntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("--------------");
        }
    }
}
