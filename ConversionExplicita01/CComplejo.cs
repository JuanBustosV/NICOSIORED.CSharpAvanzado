using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita01
{
    class CComplejo
    {
        // a+bi, a parte real, bi parte imaginaria
        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B { get; set; } // Propiedad "automática"

        public CComplejo(int pa, int pb)
        {
            a = pa;
            B = pb;
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, B);
        }

        // Creamos una conversion explicita a reales (Complejo -> real)
        public static explicit operator CReal(CComplejo pC)
        {
            CReal temp = new CReal();
            temp.R = pC.a;
            return temp;
        }
    }
}
