using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Two variables

            int a = 10;
            int b = 5;

            int sum = a + b;
            int div = a / b;
            int mul = a * b;
            int sub = a - b;

            Console.WriteLine(sum);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(sub);

            #endregion

            #region Three variables

            int x = 10;
            int y = 12;
            int z = 13;

            x += y - x++ * z;
            z = --x - y * 5;
            y /= x + 5 % z;
            int res_y = x++ + y * 5;
            int res_x = y - x++ * z;

            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(res_x);
            Console.WriteLine(res_y);

            #endregion

            #region Arithmetical mean

            int value1 = 10;
            int value2 = 12;
            int value3 = 3;

            int ar_mean = (value1 + value2 + value3) / 3;
            Console.WriteLine(ar_mean);

            #endregion

            #region  Circle square

            const double pi = Math.PI;
            double radius = 12.34;

            double res = pi * Math.Pow(radius, 2);

            Console.WriteLine(res);

            #endregion

            #region Cilinder

            double rad = 12.45;
            double height = 6.12;
            double pii = Math.PI;

            double capacity = pii * Math.Pow(rad, 2) * height;
            double surface_square = 2 + pii * rad * (radius + height);
            Console.WriteLine($"{capacity}, {surface_square}");

            #endregion
        }
    }
}
