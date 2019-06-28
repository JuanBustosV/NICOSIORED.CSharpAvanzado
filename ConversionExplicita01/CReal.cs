using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita01
{
    class CReal
    {
        // Campo o atributo
        private double r;

        // Propiedad
        public double R
        {
            get { return r; }
            set { r = value; }
        }

        // Constructor
        public CReal()
        {

        }

        public CReal(double pr)
        {
            r = pr;
        }

        public override string ToString()
        {
            return string.Format("real={0}", r);
        }
    }
}
