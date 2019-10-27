using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static int Pow(int x, int y = 2)
        {
            int res = 1;
            for (int i = 0; i < y; i++)
            {
                res *= x;
            }

            return res;
        }

        static double Method(int x, double y)
        {
            double res = x + y;
            return res;
        }

        static void Main(string[] args)
        {
            //double res = Method(10, 20.54);
            //Console.WriteLine(res);
            var res = Pow(10);
            Console.WriteLine(res);

        }
    }
}
