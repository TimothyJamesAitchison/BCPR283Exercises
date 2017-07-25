using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Model
    {
        public String PrintWord(int number)
        {
            //Switch solution
            String result;
            switch (number)
            {
                case 1:
                    result = "ONE";
                    break;
                case 2:
                    result = "TWO";
                    break;
                case 3:
                    result = "THREE";
                    break;
                case 4:
                    result = "FOUR";
                    break;
                case 5:
                    result = "FIVE";
                    break;
                case 6:
                    result = "SIX";
                    break;
                case 7:
                    result = "SEVEN";
                    break;
                case 8:
                    result = "EIGHT";
                    break;
                case 9:
                    result = "NINE";
                    break;
                default:
                    result = "OTHER";
                    break;
            }
            return result;
        }
        public String PrintWord(int number, Boolean alternativeSolution)
        {
            //Nested if solution
            String result = "OTHER";
            if (number >= 0 && number <= 9)
            {
                if (number == 1)
                {
                    result = "ONE";
                }
                if (number == 2)
                {
                    result = "TWO";
                }
                if (number == 3)
                {
                    result = "THREE";
                }
                if (number == 4)
                {
                    result = "FOUR";
                }
                if (number == 5)
                {
                    result = "FIVE";
                }
                if (number == 6)
                {
                    result = "SIX";
                }
                if (number == 7)
                {
                    result = "SEVEN";
                }
                if (number == 8)
                {
                    result = "EIGHT";
                }
                if (number == 9)
                {
                    result = "NINE";
                }
            }
            else
            {
                result = "OTHER";
            }
            return result;
        }
    }
}
