using System;
using System.Collections;//.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01BitArray
{
    class Program
    {
        internal static void MuestraArray(BitArray pArray, string pNombre = "")
        {
            int c = 0;

            Console.Write("{0}\t", pNombre);

            foreach (bool b in pArray)
            {
                c++;
                if (b)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (c % 8 == 0)
                    Console.Write(",");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            BitArray miArray = new BitArray(new byte[] { 1, 2, 4, 8, 16 });

            // Cantidad de elementos, 5 bytes * 8 bits/byte = 40 bits
            Console.WriteLine(miArray.Count);
            MuestraArray(miArray);

            Console.WriteLine("---");

            // Obtenemos un bit en particular
            Console.WriteLine(miArray.Get(3));

            // Ponemos un bit en particular
            miArray.Set(3, true);
            MuestraArray(miArray);
            Console.WriteLine(miArray.Get(3));

            Console.WriteLine("---");

            // Clonamos el bitArray
            BitArray array2 = (BitArray)miArray.Clone(); // Clone retorna object
            MuestraArray(array2, "Array 2");

            // Invertimos el array, NOT
            /*array2 = */array2.Not(); // Modifica el propio array
            MuestraArray(array2);

            Console.WriteLine("--- ");

            // Creamos otro
            BitArray array3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
            MuestraArray(array3, "Array 3");
            Console.WriteLine("--- ");

            // Hacemos OR entre arrays
            array3.Or(miArray); // array3 cambia, el resultado de or
            MuestraArray(miArray, "miArray");
            MuestraArray(array3, "array3");
            Console.WriteLine("========");

            // Hacemos AND entre arrays
            MuestraArray(miArray, "miArray");
            MuestraArray(array3, "array3");
            Console.WriteLine("========");

            // Hacemos el AND, array 3 se modifica con el resultado
            array3.And(miArray);
            MuestraArray(array3, "array3");
            Console.WriteLine("---");

            // Hacemos XOR entre arrays
            array3 = new BitArray(new byte[] { 5, 7, 9, 13, 21 });
            MuestraArray(miArray, "miArray");
            MuestraArray(array3, "array3");
            Console.WriteLine("========");

            // Hacemos el XOR, array 3 se modifica con el resultado
            array3.Xor(miArray);
            MuestraArray(array3, "array3");
            Console.WriteLine("---");
        }
    }
}
