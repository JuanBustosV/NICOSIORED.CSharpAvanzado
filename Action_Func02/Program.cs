using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tutorial C# nivel Avanzado 19 --- Delegado Genérico y Action";

            // Action nos permite crear delegados en el momento, para un maximo de 16 parametros
            // pero el tipo de retorno debe de ser VOID
            int n = 5;
            string m = "Hola a todos";

            // Usamos action para registrar el handler con el delegado
            Action<string, int> delAction = new Action<string, int>(RepiteMensaje);

            // invocamos el delegado
            delAction(m, n);

            // Func funciona similar a Action, pero permite tipo de retorno
            int x = 5;
            int y = 9;

            // Definimos el delegado, el ultimo tipo listado es siempre el tipo devuelto
            Func<int, int, int> delFunc = new Func<int, int, int>(Suma);

            // Invocamos e imprimimos el resultado
            Console.WriteLine(delFunc(x, y));
        }

        // Este metodo es el handler para Action
        static void RepiteMensaje( string pMensaje, int pVeces)
        {
            for (int i = 0; i < pVeces; i++)
                Console.WriteLine(pMensaje);
        }

        // Este metodo es el handler para Func
        static int Suma(int a, int b)
        {
            int r = 0;
            r = a + b;
            return r;
        }
    }
}
