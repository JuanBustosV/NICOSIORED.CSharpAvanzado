using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAnonimo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 20 --- Func y Métodos Anónimos";

            CPunto miPunto = new CPunto(5, 6);

            // Creamos el metodo anónimo para el delegado
            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("1. Estoy desde el metodo anónimo");
            };

            Console.WriteLine(miPunto.ToString());

            // Invocamos
            miPunto.mensaje();

            // Añadimos otro
            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("2. Este es otro método anómimo");
            };

            miPunto.mensaje();

            Console.WriteLine("----------------------------");

            // Añado otro
            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("3. Otro método anónimo más");
            };

            miPunto.mensaje();

            miPunto.mensaje = null;

            miPunto.mensaje?.Invoke(); // No se ejecuta porque vale null

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("\tJuan Bustos");
            };

            miPunto.mensaje?.Invoke(); // Aquí si se ejecuta 
        }
    }
}
