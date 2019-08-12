using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void NumberChecker(int number)
        {
            if (number > 0)
            {
            Console.WriteLine("This number {0} is positive", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("This number {0} is negative", number);     
            }
            else
            {
                Console.WriteLine("This is zero {0}", number);
            }
        }
        static void Remainder(int operand)
        {
            //Проверка числа на возможность деления без остатка на 2, 5, 3, 6, 9 с помощью условного оператора.
            if ((operand % 2) == 0 && (operand % 5) == 0 && (operand % 3) == 0 && (operand % 6) == 0 && (operand % 9) == 0)
            {
                Console.WriteLine("Число делиться без остатка на 2, 5, 3, 6, 9");
            }
            else
            {
                Console.WriteLine("Число не делиться без остатка на 2, 5, 3, 6, 9");
            }
        }

        static void Simple(int operand)
        {
            int divider = 2;   // Делитель.
            int remainder; // Остаток от деления operand на divider.

            do
            {
                //Запись остатка от деления в переменную remainder
                remainder = operand % divider;

                //Если число разделилось на делитель с остатком, увеличиваем делитель
                if (remainder != 0)
                    divider++;
            }
            while (remainder != 0); // Пока в результате деления остается остача

            if (divider == operand)
            {
                Console.WriteLine("{0} - простое число", operand);
            }
            else
            {
                Console.WriteLine("{0} - не простое число", operand);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string @string = Console.ReadLine();
            int number = Int32.Parse(@string);
            NumberChecker(number);
            Remainder(number);
            Simple(number)
        }
    }
}
