using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas02
{
    class COperaciones<T>
    {
        // Problema clase genérica no sabe si las operaciones están implementadas (sobrecargados) para el tipo T

        //public T Suma (T a, T b)
        //{
        //    return a + b;
        //}

        //public T Resta(T a, T b)
        //{
        //    return a - b;
        //}

        //public T Div(T a, T b)
        //{
        //    return a / b;
        //}

        //public T Multi(T a, T b)
        //{
        //    return a * b;
        //}

        // Truco: Usar dynamic, MEJORA, comprobar tipos válidos con typeof
        public T Suma (T a, T b)
        {
            dynamic da = a, db = b;
            return da + db;
        }

        public T Resta(T a, T b)
        {
            dynamic da = a, db = b;
            return da - db;
        }

        public T Div(T a, T b)
        {
            dynamic da = a, db = b;
            return da / db;
        }
        public T Multi(T a, T b)
        {
            dynamic da = a, db = b;
            return da * db;
        }
    }
}
