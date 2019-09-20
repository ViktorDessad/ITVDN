using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    class Program
    {
        static int TheBiggerArrElement(int element)
        {
            int[] array = new int[element];
            int i;
            int max = 0;
            for (i = 0; i < array.Length; i++)
            {
                array[i] = i;
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("User name: ");
            string userName = Console.ReadLine();
            Console.Write($"Hello {userName} ");
            Console.Write("enter array elements sum: ");
            int elementsSum = int.Parse(Console.ReadLine());
            int biggerElement = TheBiggerArrElement(elementsSum);
            Console.WriteLine(biggerElement);
            Console.ReadKey();
        }
    }
}
