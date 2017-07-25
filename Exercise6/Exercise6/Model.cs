using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Model
    {
        public int GetSum(int max)
        {
            int sum = 0;
            int count = 1;
            do
            {
                sum += count;
                count++;
            } while (count <= max);
            return sum;
        }

        public float GetAverage(int max)
        {
            return (float)this.GetSum(max) / max;
        }
    }
}
