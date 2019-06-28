using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas01
{
    // T representa al tipo con el que se trabaja en un momento dado
    class CPunto<T>
    {
        // Creamos atributos de tipo T
        private T x;
        private T y;

        // Podemos recibir parametros de tipo T
        public CPunto(T px, T py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", x, y);
        }

        public void Reset()
        {
            // Colocamos el valor de default para el tipo T
            // tipo valor 0
            // Referencias null

            x = default; // igual a default(T), más simplificado
            y = default; // default(T)
        }

        public void EncuentraTipo()
        {
            //if (typeof(T) == typeof(int))
            //    Console.WriteLine("Trabajo como entero");
            //else
            //    Console.WriteLine("No trabajo como entero. Soy de otro tipo");

            switch (typeof(T).Name)
            {
                case "Int32":
                    Console.WriteLine("Trabajo como entero: {0}", this.ToString());
                    break;
                case "Double":
                    Console.WriteLine("Trabajo como double: {0}", this.ToString());
                    break;
                case "Single":
                    Console.WriteLine("Trabajo como float: {0}", this.ToString());
                    break;
                default:
                    Console.WriteLine("Soy de otro tipo: {0}", this.ToString());
                    break;
            }            
        }
    }
}
