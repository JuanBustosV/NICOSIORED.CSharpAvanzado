using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones06
{
    class CPunto : IComparable<CPunto>
    {
        private int x;
        private int y;

        public CPunto(int px, int py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", x, y);
        }

        public int CompareTo( CPunto other)
        {
            double magnitudThis = Math.Sqrt(x * x + y * y); // como vector del origen a ese punto
            double magnitudOther = Math.Sqrt(other.x * other.x + other.y * other.y);

            if (magnitudThis > magnitudOther)
                return 1;
            if (magnitudThis < magnitudOther)
                return -1;
            else
                return 0;
        }
    }
}
