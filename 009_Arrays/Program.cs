using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Arrays
{
    class Program
    {
        static int[] PairValuesArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;             
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.Write("Size of array is: ");
            int number = Int32.Parse(Console.ReadLine());
            int[] arr = PairValuesArray(number);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine("{0} ", arr[i]);
               
            }


        }


    }
}
