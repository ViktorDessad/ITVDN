using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_001
{
    class Program
    {
        static void Main(string[] args)
        {
            ChkNum num = new ChkNum();

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
        }
    }
}
