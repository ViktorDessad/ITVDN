using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Power of two

            int s = 0;
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());

            /*Ниже представлен алгоритм определения является ли число степенью двойки. 
             Например: пользователь ввел число 8, в битовом варианте выглядит так
              00001000  //8
             &
              00000111  //7
              --------
              00000000  //s = 0  */
            s = x & (x - 1);

            if (s == 0)
            {
                Console.WriteLine("The number is a power of two.");
            }
            else
            {
                Console.WriteLine("The number is not a power of two.");
            }

            // Delay.
            Console.ReadKey();

            #endregion
        }
    }
}
