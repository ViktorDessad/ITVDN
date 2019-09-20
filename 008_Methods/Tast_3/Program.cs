using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_3
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;
            Console.WriteLine("First method part: {0}", counter);

            if (counter !=0)
            {
                Recursion(counter);
            }
            Console.WriteLine("Second method part: {0}", counter);
        }


        static void Main(string[] args)
        {
            Recursion(3);
            Console.ReadKey();
        }
    }
}
