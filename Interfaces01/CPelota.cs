﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces01
{
    class CPelota
    {
        string tamano;

        public CPelota(string pTamano)
        {
            tamano = pTamano;
        }

        public override string ToString()
        {
            return string.Format("El tamaño de la pelota es {0}", tamano);
        }
    }
}
