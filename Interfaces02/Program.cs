using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces02
{
    class Program
    {
        // Este metodo puede recibir cualquier objecto que implemente IElectronico
        static void Muestra(IElectronico aparato)
        {
            // Codigo comun 
            aparato.Encender(true);

            // Codigo segun el tipo 
            if (aparato is CTelevisor)
                Console.WriteLine("El TELEVISOR es #{0}#", aparato);
            
            if (aparato is CRadio)
                Console.WriteLine("La RADIO es #{0}#", aparato);
        }

        // Este metodo puede regresar cualquier objeto que implemente a IElectrónico
        static IElectronico CreaAparato()
        {
            IElectronico aparato = null;
            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("¿Qué deseas crear? 1-Tele, 2-Radio");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Dame la marca de la televisión: ");
                    dato = Console.ReadLine();
                    aparato = new CTelevisor(dato);
                    break;
                case 2:
                    Console.WriteLine("Dame la marca de la radio: ");
                    dato = Console.ReadLine();
                    aparato = new CRadio(dato);
                    break;
            }

            return aparato;
        }

        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 28 --- Manejo de interfaces con métodos";

            // Arrays de interfaces

            IElectronico[] teles = { new CTelevisor("Charp"), new CTelevisor("Zony"), new CRadio("RCB"), new CTelevisor("Filips") };
            IElectronico aparatoCreado = null;

            for (int n = 0; n < teles.Length; n++)
                Console.WriteLine(teles[n]);

            Console.WriteLine("---");

            // Uso de interfaces con metodos
            CTelevisor miTV = new CTelevisor("Charp TV");
            CRadio miRadio = new CRadio("RCB Radio");

            Muestra(miRadio);
            Muestra(miTV);

            Console.WriteLine("---");

            // Metodo que regresa objeto que implementa la interface
            aparatoCreado = CreaAparato();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);
        }
    }
}
