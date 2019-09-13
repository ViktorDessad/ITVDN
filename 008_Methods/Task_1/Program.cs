using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static int Calculate(int a, int b, int c)
        {
            b = b + 1;
            c = c + 1;
            return a + 1;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            int aa = Calculate(a, b, c);
            Console.WriteLine("{0} {1} {2}", aa, b, c);
        }
    }
}
