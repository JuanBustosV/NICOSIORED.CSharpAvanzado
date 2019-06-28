using System;
using System.Collections;//.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 5 --- HashTable I";

            Hashtable miTabla = new Hashtable();

            // Añadimos elementos al Hashtable
            miTabla.Add(123, "Hola");
            miTabla.Add(234, "Saludos");
            miTabla.Add(45, "Adios");
            miTabla.Add(567, "C#");
            miTabla.Add(12763, "Programacion");

            // Mostramos los elementos
            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            // Intentamos colocar un elemento con llave repetida
            //miTAbla.Add(123, "Otro mas");

            Console.WriteLine("---");

            // Cantidad de elementos
            Console.WriteLine(miTabla.Count);

            Console.WriteLine("---");

            // Obtenemos el elemento de determinada llave
            Console.WriteLine("Valor: #{0}#", miTabla[567]);
            Console.WriteLine("Valor: #{0}#", miTabla[455]); // null?

            Console.WriteLine("---");

            // Colocamos elemento en una llave
            miTabla[45] = "Avanzado";
            miTabla[300] = "Colecciones"; // Esto también  agrega (Add)

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            Console.WriteLine("---");

            // Verificamos si hay un elemento
            Console.WriteLine(miTabla.Contains(567));
            Console.WriteLine(miTabla.ContainsKey(567));
            Console.WriteLine(miTabla.Contains(335));


            // Eliminamos un elemento
            miTabla.Remove(234); // si no existe no pasa nada, no hace nada

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            Console.WriteLine("---");

            foreach (int llave in miTabla.Keys) // se que mi llave es int
            {
                Console.WriteLine(llave);
            }

            Console.WriteLine("---");

            foreach (string valor in miTabla.Values) // se que mis valores son string
            {
                Console.WriteLine(valor);
            }
        }
    }
}
