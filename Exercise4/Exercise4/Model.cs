﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Model
    {
        public int GetSum(int max)
        {
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            return sum;
        }

        public float GetAverage(int max)
        {
            return (float) this.GetSum(max) / max;
        }
    }
}
