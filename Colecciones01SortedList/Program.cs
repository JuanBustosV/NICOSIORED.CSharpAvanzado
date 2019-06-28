using System;
using System.Collections;//.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 8 --- SortedList";

            SortedList miSLista = new SortedList();

            // Agregamos, ordenada según la key
            miSLista.Add(754, "Honda"); // key y value
            miSLista.Add(123, "Volvo");
            miSLista.Add(587, "Nissan");
            miSLista.Add(323, "Fiat");

            // Iteramos
            foreach (DictionaryEntry elemento in miSLista)
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

            Console.WriteLine("---------");

            // Cantidad de elementos
            Console.WriteLine(miSLista.Count);

            // Contiene elemento
            Console.WriteLine(miSLista.Contains(123));
            Console.WriteLine(miSLista.Contains(678));

            Console.WriteLine(miSLista.ContainsKey(587));
            Console.WriteLine(miSLista.ContainsValue("Volvo"));
            Console.WriteLine(miSLista.ContainsValue("volvo"));

            Console.WriteLine("---------");

            // Obtenemos elemento por indice
            Console.WriteLine(miSLista.GetKey(2)); // llave
            Console.WriteLine(miSLista.GetByIndex(2)); // valor
        }
    }
}
