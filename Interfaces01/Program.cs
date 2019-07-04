using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 27 --- Conocer cuando el objeto implementa a la interfaz";

            // Como reconocer si un objeto implementa a determinada interface

            CTelevisor miTele = new CTelevisor("Sharpy");
            CPelota miPelota = new CPelota("Grande");
            IElectronico objeto = null;

            // Método 1, por excepción

            try
            {
                Console.WriteLine("Probamos la tele");
                objeto = (IElectronico)miTele;
                objeto.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Probamos la pelota");
                objeto = (IElectronico)miPelota; // El casting si no puede da excepción
                objeto.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----");

            // Metodo 2, por as (puede ser tratado como)

            Console.WriteLine("Probamos la tele");
            objeto = miTele as IElectronico; // o null si no puede ser tratado

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la pelota");
            objeto = miPelota as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No Implementa IElectronico");

            Console.WriteLine("----");

            // Método 3, por is (p es complatible con)

            Console.WriteLine("Probamos la tele");

            if (miTele is IElectronico)
                miTele.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la pelota");

            if (miPelota is IElectronico)
                Console.WriteLine("Wow tienes una pelota electrónica");
            else
                Console.WriteLine("No implementa IElectronico");
        }
    }
}
