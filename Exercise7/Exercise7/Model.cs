using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Model
    {
        public int GetSum(int min, int max)
        {
            int sum = 0;
            for (int i = min; i<= max; i++)
            {
                sum += i;
            }
            return sum;
        }

        public float GetAverage(int min, int max)
        {
            int count = max - min + 1;
            return (float) this.GetSum(min, max) / count;
        }
    }
}
