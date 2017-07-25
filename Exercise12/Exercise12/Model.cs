using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Model
    {
        public float HarmonicForwards(int max)
        {
            float result = 0;
            for (int i = 1; i <= max; i++)
            {
                result += (float)1 / i;
            }
            return result;
        }

        public float HarmonicBackwards(int max)
        {
            float result = 0;
            for (int i = max; i >= 1; i--)
            {
                result += (float)1 / i;
            }
            return result;
        }

    }
}
