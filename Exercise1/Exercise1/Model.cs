using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Model
    {
        public String CheckMark(int mark)
        {
            String result;
            if(mark >= 50)
            {
                result = "PASS";
            }
            else
            {
                result = "FAIL";
            }
            return result;
        }
    }
}
