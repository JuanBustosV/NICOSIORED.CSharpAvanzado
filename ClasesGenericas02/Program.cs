using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 18 --- Problemas con clases genéricas";

            // Ver la clase COperaciones, no es posible compilar
            // Usamos dynamic para resolverlo, el tipo se checa en ejecución

            COperaciones<int> miOperacion = new COperaciones<int>();
            COperaciones<string> miOperacionS = new COperaciones<string>();

            Console.WriteLine(miOperacion.Suma(5,4));
            Console.WriteLine(miOperacion.Multi(5,4));
            Console.WriteLine(miOperacionS.Suma("hola ","a todos"));
            //Console.WriteLine(miOperacionS.Multi("hola ","a todos")); PETA!
        }
    }
}
