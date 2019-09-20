using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; // 0 - 9

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = i;
                Console.WriteLine("Array element {0}", array[i]);
            }
            Console.ReadKey();
        }
    }
}
