using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 10 --- Introducción a las Colecciones Genéricas";

            List<int> valores = new List<int>();
            int n, r;            

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);
            valores.Add(8);

            // Recorremos con bucle for
            for (n = 0; n < valores.Count; n++)
            {
                // No hay necesidad de type cast
                r = valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("-----");

            // Vemos si contiene a determinado elemento
            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(17));

            Console.WriteLine("-----");

            // Obtenemos indice de un elemento
            Console.WriteLine(valores.IndexOf(4));
            Console.WriteLine(valores.IndexOf(54));

            Console.WriteLine("-----");

            // Insertamos elemento en un indice particular
            valores.Insert(2, 55);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("-----");

            // Eliminamos elemento en un indice
            valores.RemoveAt(3);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("-----");

            // Eleminamos la primera ocurrencia de un valor
            valores.Remove(8);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("-----");

            // La lista se coloca en sentido contrario
            valores.Reverse();

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("-----");
            // Examen 20483
            Console.WriteLine(valores.GetType().GetGenericTypeDefinition());
            Console.WriteLine(valores.GetType());
            Console.WriteLine(valores.GetType().GetProperties());
            Console.WriteLine(valores is List<int>);
            Console.WriteLine(valores.GetType() == typeof(List<int>));
            Console.WriteLine(valores.GetType().GetGenericTypeDefinition() == typeof(List<>));

            Console.WriteLine("-----");

            Type type1 = typeof(Program);
            object obj = Activator.CreateInstance(type1);
            Console.WriteLine(obj.GetType());
            // fin pruebas examen 70483

            // Ordenamos la lista
            valores.Sort();

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("-----");

            // Creamos una lista para nuestra clase CPunto

            List<CPunto> listaPuntos = new List<CPunto>();

            listaPuntos.Add(new CPunto(5, 3));
            listaPuntos.Add(new CPunto(7, 8));
            listaPuntos.Add(new CPunto(12, 5));
            listaPuntos.Add(new CPunto(6, 2));

            foreach (CPunto punto in listaPuntos)
                Console.WriteLine(punto);

            // No funciona porque no hemos implementado IComparable
            //listaPuntos.Sort();
        }
    }
}
