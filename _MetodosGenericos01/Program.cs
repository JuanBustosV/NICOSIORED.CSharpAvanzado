using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MetodosGenericos01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 16 --- Métodos genéricos";

            int x = 5;
            int y = 3;

            Console.WriteLine("x={0}, y={1}", x, y);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("x={0}, y={1}", x, y);

            double m = 78.9;
            double n = 98.6;

            Console.WriteLine("m={0}, n={1}", m, n);
            Intercambio<double>(ref m, ref n);
            Console.WriteLine("m={0}, n={1}", m, n);

            string o = "Hola";
            string p = "Juan Mnemonic";

            Console.WriteLine("o={0}, p={1}", o, p);
            Intercambio<string>(ref o, ref p);
            Console.WriteLine("o={0}, p={1}", o, p);
        }

        static void Intercambio<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
