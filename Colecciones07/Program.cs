using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // No olvidar este using
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 14 --- ObservableCollection";
            // Coleccion observable

            ObservableCollection<CPunto> puntos = new ObservableCollection<CPunto>()
            {
                new CPunto(4, 55),
                new CPunto(17, 22)
            };

            // Agregar el handler al evento
            puntos.CollectionChanged += puntos_CollectionChanged;

            puntos.Add(new CPunto(2, 3));

            CPunto miPunto = new CPunto(5, 5);

            puntos.Add(miPunto);

            puntos.Remove(miPunto);

            Console.WriteLine("Elementos actuales en puntos:");
            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p.ToString());
            }
        }

        // Este es el handler que se invoca cuando cambia la coleccion
        static void puntos_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Vemos el tipo de evento que ocurrio
            Console.WriteLine("El evento es {0}", e.Action);

            // Si la accion es agregar
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("\tElementos nuevos:");
                foreach (CPunto p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }

            // Si la accion fue remover
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tElemento afectados por el cambio:");
                foreach (CPunto p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
