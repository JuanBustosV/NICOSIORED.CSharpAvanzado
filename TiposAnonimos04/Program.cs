using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAnonimos04 // sobre todo uso con LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 24 --- Conversión implicita y tipos anónimos";

            // Creamos tipos anonimos
            // Crea un tipo temporal con atributos, propiedades, ToString 

            // Creamos el tipo anonimo, tiene los métodos propios de object
            var miCompu = new { Procesador = "i7", Memoria = 16, Graficos = "intel" };
            //miCompu. // métodos de object

            // Imprimimos la variable
            Console.WriteLine(miCompu);

            // Imprimimos un atributo
            Console.WriteLine("La computadora tiene {0} de memoria", miCompu.Memoria);

            // No podemos modificar el atributo, es de solo lectura
            //miCompu.Graficos = "nvidia";
        }
    }
}
