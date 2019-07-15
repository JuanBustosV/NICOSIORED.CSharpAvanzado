using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 28 --- Manejo de interfaces con métodos";

            // Arrays de interfaces

            IElectronico[] teles = { new CTelevisor("Charp"), new CTelevisor("Zony"), new CRadio("RCB"), new CTelevisor("Filips") };
        }
    }
}
