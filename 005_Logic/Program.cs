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

            #region De Morgan

            bool A = true;
            bool B = true;

            bool C = A | B;

            bool res = !(A & B);

            Console.WriteLine("{0}, {1}", C, res);

            #endregion

            #region Even numbers with AND

            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = 1;

            int num3 = num2 & num1;

            if (num3 == 0)
            {
                Console.WriteLine("This is {0} - even number", num1);
            }
            else
            {
                Console.WriteLine("This is {0} - odd number", num1);
            }

            #endregion

            #region Even number ver.2

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int res1 = number << 31;

            if (res1 == 0)
            {
                Console.WriteLine("This is {0} even number", number);
            }
            else
            {
                Console.WriteLine("This is {0} odd number", number);
            }

            #endregion

            #region Even number ver.3

            Console.Write("Enter a number: ");
            int number00 = Convert.ToInt32(Console.ReadLine());

            double number0 = number / 2.0;
            int number1 = number / 2;

            
            if (Math.Abs(number0 - number1) == 0)
            {
                Console.WriteLine("This is {0} even number", number00);
            }
            else
            {
                Console.WriteLine("This is {0} odd number", number00);
            }

            #endregion

            #region Tasks

            int x11 = 5, y = 10, z = 15;
            //Отображение результатов выполнения выражений содержащих в себе логические выражения.
            Console.WriteLine("1-е уравнение = {0}", x11 += y >> x11++ * z);
            Console.WriteLine("2-е уравнение = {0}", z = ++x11 & y * 5);
            Console.WriteLine("3-е уравнение = {0}", y /= x11 + 5 | z);
            Console.WriteLine("4-е уравнение = {0}", z = x11++ & y * 5);
            Console.WriteLine("5-е уравнение = {0}", x11 = y << x11++ ^ z);

            #endregion

            #region Salary for workers

            Console.Write("Enter primary salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many years the worker works: ");
            int years = Convert.ToInt32(Console.ReadLine());

            if (years >= 0 && years <= 5)
            {
                double totalAmmount = salary + (salary * 0.1);
                Console.WriteLine("The bonus amount will be 10% of the salary - {0}", salary);
                Console.WriteLine("The finaly amount will be {0}$", totalAmmount);
            }

            else if (years >= 5 && years <= 10)
            {
                double totalAmmount = salary + (salary * 0.15);
                Console.WriteLine("The bonus amount will be 15% of the salary - {0}", salary);
                Console.WriteLine("The finaly amount will be {0}$", totalAmmount);
            }
            else if (years > 10 && years <= 15)
            {
                double totalAmmount = salary + (salary * 0.25);
                Console.WriteLine("The bonus amount will be 25% of the salary - {0}", salary);
                Console.WriteLine("The finaly amount will be {0}$", totalAmmount);
            }
            else if (years > 15 && years <= 20)
            {
                double totalAmmount = salary + (salary * 0.35);
                Console.WriteLine("The bonus amount will be 35% of the salary - {0}", salary);
                Console.WriteLine("The finaly amount will be {0}$", totalAmmount);
            }
            else if (years > 20 && years <= 25)
            {
                double totalAmmount = salary + (salary * 0.45);
                Console.WriteLine("The bonus amount will be 45% of the salary - {0}", salary);
                Console.WriteLine("The finaly amount will be {0}$", totalAmmount);
            }
            else if (years > 25)
            {
                double totalAmmount = salary + (salary * 0.5);
                Console.WriteLine("The bonus amount will be 50% of the salary - {0}", salary);
                Console.WriteLine("The finaly amount will be {0}$", totalAmmount);
            }


            #endregion
        }
    }
}
