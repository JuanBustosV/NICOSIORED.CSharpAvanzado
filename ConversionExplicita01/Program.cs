using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 23 --- Conversión explicita";

            // Conversion custom de tipo
            CComplejo comp1 = new CComplejo(2, 3);

            // No se puede de forma implicita
            //CReal real1 = comp1;

            // Tampoco se puede hasta que coloquemos el explicit
            CReal real2 = (CReal) comp1; // invoca al metodo de conversión en CComplejo.cs
            Console.WriteLine(real2);
            Console.WriteLine(comp1);
        }
    }
}
