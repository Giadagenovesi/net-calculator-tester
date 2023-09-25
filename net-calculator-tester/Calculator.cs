using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        public static float Somma(float a, float b)
        {
            return a + b;
        }

        public static float Sottrazione(float c, float d)
        {
            return c - d;
        }

        public static float Moltiplicazione(float e, float f)
        {
            return e * f;
        }

        public static float Divisione(float g, float h)
        {
            if (h == 0)
            {
                throw new Exception("Non puoi dividere per 0");
            }
            return g / h;
        }
    }
}
