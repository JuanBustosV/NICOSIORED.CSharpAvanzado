using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __VarNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 15 --- Var, Nullable, Dynamic";

            // DECLARACION IMPLICITA de variables
            // Solo se permiten en variables locales
            // No se pueden usar en atributos
            // No se puedden usar como tipos de retorno
            // Se debe de colocar un valor en el momento de la declaracion y no puede ser null
            // No confundir con var o Variant de otros lenguajes, es fuertemente tipificado
            // Se usan en LINQ donde un query puede dar un resultado dinamicamente creado

            var a = 5;
            var b = "Hola a todos";
            var c = 15.869;
            var d = false;
            //var e = null;
            //d = 58;
            var f = c;

            // Imprimimos
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            // Usamos reflexion para conocer el tipo
            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("b es {0}", b.GetType().Name);
            Console.WriteLine("c es {0}", c.GetType().Name);
            Console.WriteLine("d es {0}", d.GetType().Name);
            Console.WriteLine("f es {0}->{1}", f.GetType().Name, f);

            Console.WriteLine("-----------------");

            // TIPOS NULLEABLES
            // Los tipos de valor (struct) no pueden tener un null (solo de referencia, class)

            //int valor = null;

            // Los tipos nulleables pueden representar los mismos valores mas el valor de NULL
            // Son utiles en bases de datos, pues podemos encontrar columnas no definidas
            // Para definirlo usamos ?
            // Pero realmente creamos una instancia de System.Nullable<T>

            int? dato = 5;
            Console.WriteLine("dato {0}", dato);
            dato = null;
            Console.WriteLine("dato {0}", dato);

            double? precio = null;
            precio = 6.7;
            Console.WriteLine(precio);

            // El string no es nulleable ya que es un tipo por referencia
            //string? nombre = "Kevin";
            string nombre = null; 

            // Podemos saber si tiene o no tiene valor
            precio = null;
            //nombre.HasValue(); <- solo para nullables


            if (precio.HasValue)
                Console.WriteLine("Tiene valor {0}", precio.Value);
            else
                Console.WriteLine("No tiene valor");

            // El operador ?? nos permite asignar un valor en caso de que tenga null

            double? numero = asignador() ?? 5.55;

            Console.WriteLine(numero);
        }

        public static double? asignador()
        {
            //return 4.5;
            return null;
        }
    }
}
