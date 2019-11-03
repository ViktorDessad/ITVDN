using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_001
{
    class ChkNum
    {
        // This method returned "true", if parameter "x" equals prime number
        public bool IsPrime(int x)
        {
            if (x <= 1)
            {
                return false;
            }

            for (int i = 2; i <= x / i; i++)
            {
                if ((x % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
