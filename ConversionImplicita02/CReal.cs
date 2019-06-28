using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicita02
{
    class CReal
    {
        // Propiedad
        public double R { get; set; }

        // Constructor
        public CReal()
        {

        }

        public CReal(double pr)
        {
            R = pr;
        }

        public override string ToString()
        {
            return string.Format("real={0}", R);
        }

        // Creamos una conversion implicita de reales a complejos
        public static implicit operator CComplejo(CReal pR)
        {
            CComplejo temp = new CComplejo((int)pR.R, 0);

            return temp;
        }
    }
}
