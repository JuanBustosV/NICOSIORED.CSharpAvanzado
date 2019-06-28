using System;
using System.Collections;//.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Colecciones dentro de System.Collection (de cualquier tipo, guardado como OBJECT) "poco eficientes debido al casting"
            // ArrayList
            // BitArray
            // HashTable (k,v)
            // Queue
            // SortedList (k,v) k,[]
            // Stack

            ArrayList palabras = new ArrayList(); // Seleccionando la clase y pulsar F1 abre la documentación de Microsoft en el navegador

            // Podemos agregar un rango
            palabras.AddRange(new string[] { "hola", "Juan", "Bustos" });

            Console.WriteLine("Cantidad de elementos en el ArrayList es {0}.", palabras.Count);

            // Recorremos con bucle for
            for (int n = 0; n < palabras.Count; n++)
                Console.Write(" {0}", palabras[n]);

            Console.WriteLine();
            Console.WriteLine("----");

            // Otra forma de agregar elementos
            palabras.Add("Granada es de primera");
            
            // Recorremos con foreach
            foreach (string palabra in palabras)
            {
                Console.Write(" {0}", palabra);
            }

            Console.WriteLine();
            Console.WriteLine("----");

            ArrayList valores = new ArrayList();
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            // Recorremos con for
            for (int i = 0, r; i < valores.Count; i++)
            {
                r = (int) valores[i]; // El namespace de Collections, las collecciones guardan sus elementos como OBJECT !!!
                Console.WriteLine(r);
            }

            Console.WriteLine("----");

            // Vemos si existe un elemento en el ArrayList
            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));
            Console.WriteLine("----");

            // Insertamos en un indice en particular
            valores.Insert(2, 55);

            for (int i = 0, r; i < valores.Count; i++)
            {
                r = (int)valores[i]; // El namespace de Collections, las collecciones guardan sus elementos como OBJECT !!!
                Console.WriteLine(r);
            }

            Console.WriteLine("----");

            // Eliminar elemento
            valores.Remove(55);

            for (int i = 0, r; i < valores.Count; i++)
            {
                r = (int)valores[i]; // El namespace de Collections, las collecciones guardan sus elementos como OBJECT !!!
                Console.WriteLine(r);
            }

            Console.WriteLine("----");

            // Eliminar elemento de una posición
            valores.RemoveAt(0); // Estar seguro que existe ese indice o posición

            for (int i = 0, r; i < valores.Count; i++)
            {
                r = (int)valores[i]; // El namespace de Collections, las collecciones guardan sus elementos como OBJECT !!!
                Console.WriteLine(r);
            }

            Console.WriteLine("----");
        }
    }
}
