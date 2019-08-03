using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Rectangle

            int num = 10;
            int num1 = 10;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        #endregion

        #region Number sum

        Label1:
            Console.Write("Enter a first number: ");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int num02 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int res = 0;

            if (num02 > num01)
            {
                for (int i = num01; num01 < num02; num01++)
                {
                    sum += num01;
                    res = sum - i;
                    Console.WriteLine($"{res}");
                }
                Console.WriteLine($"The sum is: {res}");
            }
            else
            {
                Console.WriteLine("Error, please try again");
                goto Label1;
            }


            #endregion

            #region Odd numbers


            Console.Write("Enter a first number: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            for (int i = numA; i < numB; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region Triangle

            int number = 10;


            for (int i = 1; i < number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            #endregion

            #region Triangle ver.2

            int number1 = 10;


            for (int i = 1; i < number; i++)
            {
                for (int j = number1; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            #endregion

            #region Equilateral triangle

            int number2 = 20;


            for (int i = 1; i < number2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            #endregion

            int x = 10;
            int z = 1;
            int y = 14;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Отступ от края консоли
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                //Уменьшение значения отступа от левого края консоли
                y -= 1;
                ////Увеличиваем количество звездочек на 2
                z += 2;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}





                       
           



            
