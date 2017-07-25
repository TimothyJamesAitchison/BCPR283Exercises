using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Model
    {
        public int GetSum(int min, int max)
        {
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public float GetAverage(int min, int max)
        {
            int count = max - min + 1;
            return (float)this.GetSum(min, max) / count; 
        }
    }
}
