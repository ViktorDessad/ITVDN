using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_001
{
    class Program
    {
        static int SumArguments(out int [] arr)
        {
            int argumentNum = Int32.Parse(Console.ReadLine());
            int[] array = new int[argumentNum];
            arr = new int [argumentNum];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                sum += array[i];
                arr [i] = array[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int [] arr;
            int res = SumArguments(out arr);
            Console.WriteLine("The result = {0} ", res);

            for (int i = 0; i < arr.Length; i++)
            {
            Console.WriteLine(arr[i]);
            }
        }
    }
}
