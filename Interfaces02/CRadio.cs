using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces02
{
    class CRadio:IElectronico
    {
        string marca;

        public CRadio(string pMarca)
        {
            marca = pMarca;
        }

        public override string ToString()
        {
            return string.Format("La radio es marca {0}", marca);
        }

        public void Encender(bool pInterruptor) // método de la interfaz IElectronico
        {
            if (pInterruptor)
                Console.WriteLine("Encendido");
            else
                Console.WriteLine("Apagado");
        }
    }
}
