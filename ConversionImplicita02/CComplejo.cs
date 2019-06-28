using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicita02
{
    class CComplejo
    {
        public int A { get; set; }

        public int B { get; set; } // Propiedad "automática"

        public CComplejo(int pa, int pb)
        {
            A = pa;
            B = pb;
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", A, B);
        }

        // Creamos una conversion explicita a reales (Complejo -> real)
        public static explicit operator CReal(CComplejo pC)
        {
            CReal temp = new CReal();
            temp.R = pC.A;
            return temp;
        }
    }
}
