using System;
using System.Collections;//.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 7 --- Queue";

            Queue cola = new Queue(); // FIFO

            // Agregamos objetos
            cola.Enqueue(203);
            cola.Enqueue(false);
            cola.Enqueue(34.9232);
            cola.Enqueue("Manzana");
            cola.Enqueue("Fresa");            
            cola.Enqueue("Pera");
            

            // Iteramos (rompe filosofía Cola), pero por ser collección se puede iterar
            foreach (var fruta in cola)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("------");

            // Obtenemos objeto
            Console.WriteLine("Dequeue {0}", cola.Dequeue()); // lo quita de la cola, FIFO
            Console.WriteLine("Dequeue {0}", cola.Dequeue());
            Console.WriteLine("Dequeue {0}", cola.Dequeue());
            foreach (var fruta in cola)
                Console.WriteLine("Después dequeue ->\t{0}", fruta);

            Console.WriteLine("-------");

            // Agregamos objetos
            cola.Enqueue("Limón");
            cola.Enqueue("Mango");
            cola.Enqueue("Ciruela");

            // Observamos el objeto
            Console.WriteLine("Peek {0}", cola.Peek()); // No lo quita de la cola
            foreach (string fruta in cola)
                Console.WriteLine("Después de peek ->\t{0}", fruta);

            Console.WriteLine("-------");


            // Conteo de objetos
            Console.WriteLine(cola.Count);

            Console.WriteLine("-------");

            // Verificamos si existe elemento
            Console.WriteLine(cola.Contains("Mango"));
            Console.WriteLine(cola.Contains("Manzana"));
            Console.WriteLine(cola.Contains(203));
        }
    }
}
