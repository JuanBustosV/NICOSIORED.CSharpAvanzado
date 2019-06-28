using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones05
{
    class CPunto
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
    }
}
