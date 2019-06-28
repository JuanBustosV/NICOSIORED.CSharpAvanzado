using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicita02 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 24 --- Conversión implicita y tipos anónimos";

            // Conversion custom de tipo
            CComplejo comp1 = new CComplejo(2, 3);

            // No se puede de forma implicita
            //CReal real1 = comp1;

            // Tampoco se puede hasta que coloquemos el explicit
            CReal real2 = (CReal)comp1; // invoca al metodo de conversión en CComplejo.cs
            Console.WriteLine(real2);
            Console.WriteLine(comp1);
            Console.WriteLine("---------------------------------");

            // Aquí la conversion implicita, de Real -> Complejo, CReal.cs
            CReal real3 = new CReal(3.5);

            CComplejo comp2 = real3;

            Console.WriteLine(comp2);
            Console.WriteLine(real3);
        }
    }
}
