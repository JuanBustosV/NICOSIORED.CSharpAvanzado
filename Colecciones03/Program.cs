using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 12 --- List Genérica II";

            // Lista de objetos de nuestra clase CPunto
            // Adicion explicita, no con Add
            List<CPunto> puntos = new List<CPunto>
            {
                new CPunto(2,3),
                new CPunto(5,23),
                new CPunto(7,9)
            };

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-----");

            // Agrego un punto
            puntos.Add(new CPunto(45, 90));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-----");

            // Insertamos un punto
            puntos.Insert(2, new CPunto(100, 150));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-----");

            // Copiamos de lista a array
            CPunto[] arrayPuntos = puntos.ToArray();

            for (int n = 0; n < arrayPuntos.Length; n++)
            {
                Console.WriteLine(arrayPuntos[n]);
            }

            Console.WriteLine("------");
        }
    }
}
