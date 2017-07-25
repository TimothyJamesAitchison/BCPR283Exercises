using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Model
    {
        public int GetSum(int max)
        {
            int sum = 0;
            int count = 1;
            while(count <= max)
            {
                sum += count;
                count++;
            }
            return sum;
        }

        public float GetAverage(int max)
        {
            return (float)this.GetSum(max) / max;
        }
    }
}
