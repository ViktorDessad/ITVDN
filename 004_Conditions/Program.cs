using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Word translator

        Label:
            Console.WriteLine("Enter weather");

            string word = Console.ReadLine();

            switch (word)
            {
                case "rainy":
                    Console.WriteLine("Дождливо");
                    break;
                case "windy":
                    Console.WriteLine("Ветряно");
                    break;
                case "cloudly":
                    Console.WriteLine("Хмарно");
                    break;
                case "cold":
                    Console.WriteLine("Холодно");
                    break;
                case "hot":
                    Console.WriteLine("Жарко");
                    break;
                default:
                    Console.WriteLine("This weater does not exist");
                    goto Label;
            }

        #endregion

            #region Simple Calculator

        Label1:
            Console.Write("Enter first operand: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("and the second: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Label2:
            Console.Write("Enter sign (/,+,-,*):");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    double sum = operand1 + operand2;
                    Console.WriteLine("The sum is: {0} + {1} = {2}", operand1, operand2, sum);
                    break;
                case "-":
                    double sub = operand1 - operand2;
                    Console.WriteLine("The sub is: {0} - {1} = {2}", operand1, operand2, sub);
                    break;
                case "*":
                    double mul = operand1 + operand2;
                    Console.WriteLine("The mul is: {0} * {1} = {2}", operand1, operand2, mul);
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        double div = operand1 / operand2;
                        Console.WriteLine("The div is: {0} / {1} = {2}", operand1, operand2, div);
                    }
                    else
                    {
                        Console.WriteLine("You cannot divide by zero, please try again");
                        goto Label1;
                    }
                    break;
                default:
                    Console.WriteLine("Enter the right sign");
                    goto Label2;       
            }
            #endregion

            #region Numbers detector
            Number:
            Console.Write("Please enter number from 0 to 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 100)
            {
                if (number >= 0 && number <= 14)
                    Console.WriteLine("This number {0} is in this 0-14 range", number);
                if (number >= 15 && number <= 35)
                    Console.WriteLine("This number {0} is in this 15-35 range", number);
                if (number >= 36 && number <= 50)
                    Console.WriteLine("This number {0} is in this 36-50 range", number);
                if (number >= 50 && number <= 100)
                    Console.WriteLine("This number {0} is in this 0-14 range", number);
            }
            else
            {
                Console.WriteLine("This number {0} less than 0 and biggest than 100, please try again", number);
                goto Number;
            }

            #endregion
        }
    }
}
                

