using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 22 --- Expresiones Lambda";

            // Hacemos lo mismo que en el ejemplo anterior pero con expresion lambda
            // Solo se pueden usar donde se haga uso de un metodo anonimo o un delegado
            // fuertemente tipificado

            // Lista de parametros => instrucciones a realizar
            // El tipo de los parametros puede ser implicito o explicito (int i)

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Hacemos uso de la expresion lambda
            List<int> numPares = numeros.FindAll(i => i % 2 == 0);

            // lo mismo con metodo anonimo
            List<int> numPares2 = numeros.FindAll(
                delegate (int i) 
                {
                    if (i % 2 == 0)
                        return true;
                    else return false;
                }
            );

            // Mostramos los números
            foreach (int n in numPares)
                Console.WriteLine(n);
        }
    }
}
