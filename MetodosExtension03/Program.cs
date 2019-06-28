using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 25 --- Métodos de extensión";

            // Este programa muestra el uso de metodos de extension

            // Extension del int
            int numero = 55;

            bool par = numero.EsPar(); // Aquí encontramos la extensión!!!

            Console.WriteLine("¿{0} es par?: {1}", numero, par);

            // Extension del double
            double valor = 55.18;

            Console.WriteLine(valor.Dobletea());

            // Extension ISaludador
            MiInt entero = new MiInt(7);

            entero.Sonido();
        }
    }
}
