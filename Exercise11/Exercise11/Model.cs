using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Model
    {
        public int GetProduct(int max)
        {
            int product = 1;
            for(int i = 1; i <= max; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
