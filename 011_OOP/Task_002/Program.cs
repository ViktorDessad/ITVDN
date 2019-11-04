using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    class ChkNum
    {
        public bool IsPrime(int x)
        {
            if (x <= 1)
	        {
                return false;
	        }

            for (int i = 2; i < x/i; i++)
			{
                if ((x % i) == 0)
	            {
                    return false;
	            }
                
			}
            return true; 
        }

        public int LeastComFactor(int a, int b)
        {
            int max;

            if (IsPrime(a) || IsPrime(b))
	        {
                return 1;
        	}

            max = a < b ? a : b;

            for (int i = 2; i <= max/2; i++)
			{
                if (((a%i)==0) && ((b%i)==0))
	            {
                    return i;
	            }
			}
            return 1;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ChkNum num = new ChkNum();
            int a, b;

            for (int i = 2; i < 10; i++)
			{
                if (num.IsPrime(i))
	            {
                    Console.WriteLine($"{i} - prime number");
	            }
                else
                {
                    Console.WriteLine($"{i} - composite number");
                }
			}

            a = 100;
            b = 75;
            Console.WriteLine($"Res - {num.LeastComFactor(a, b)}");
            Console.ReadKey();
        }
    }
}
