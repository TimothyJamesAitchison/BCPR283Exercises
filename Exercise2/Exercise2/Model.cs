using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Model
    {
        public String CheckNumber(int number)
        {
            String result;
            if (number % 2 != 0)
            {
                result = "Odd Number";
            }
            else
            {
                result = "Even Number";
            }
            return result;
        }
    }
}
