using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 21 --- Predicado / Predicate";

            // Ejemplo con delegados

            // System.Predicate<T> es un delegado generico que representa un metodo que
            // va a definir un criterio y dice si el objecto cumple o no con ese criterio
            // public List<T> FindAll(Predicate<T> match) Recorre los elementos de la lista y
            // los pasa como parametro al delegado, si ese retresa true los pone en la lista de retorno.

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 8, 11, 12, 3, 7, 20 });

            // Indicamos el delegado
            Predicate<int> delegadoP = new Predicate<int>(Pares);
            Predicate<int> delegadoR = new Predicate<int>(Rango);

            // Invocamos el metodo
            List<int> numPares = numeros.FindAll(delegadoP);
            List<int> numRango = numeros.FindAll(delegadoR);

            // Mostramos numPares
            foreach (int n in numPares)
                Console.WriteLine(n);

            Console.WriteLine("---------------");

            foreach (int n in numRango)
                Console.WriteLine(n);

            numeros.RemoveAll(delegadoR); // Otro metodo que usa Predicate<T>

            Console.WriteLine("---------------");

            foreach (int n in numeros)
                Console.WriteLine(n);

        }

        // Este es el delegado
        static bool Pares(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }

        // Otro criterio, rango [3,7]
        static bool Rango(int n)
        {
            if (n >= 3 && n <= 7)
                return true;
            else return false;
        }
    }
}
