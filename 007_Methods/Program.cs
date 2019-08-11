using System;

namespace _007_Methods
{
    class Program
    {


        #region 1. This method does not take a value, and does not return a value
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        #endregion

        #region 2. This method take a value, but does not return he just call it
        static void Hello1(string word)
        {
            Console.WriteLine(word);
        }
        #endregion

        #region 3. This method take a value and returned it
        static int Add(int oper1, int oper2)
        {
            return oper1 + oper2;
        }
        #endregion

        #region 4. This method does not take a value, but he returned it

        static int Add1()
        {
            int a = 21;
            int b = 3;
            int sum = a + b;
            return sum;
        }
        #endregion

        #region 5. Concatenation

        static string MakeConcatenation(string name)
        {
            string phrase = "Hello" + name + "!";

            return phrase;
        }

        #endregion

        // Home tasks

        #region 6. Method Calculate

        static int Calculate (int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
        #endregion

        #region 7. Calculator

        static void ADD(int operand1, int operand2)
        {
            int result = operand1 + operand2;
            Console.WriteLine("The result is {0}", result);
        }
        static void Sub(int operand1, int operand2)
        {
            int result = operand1 - operand2;
            Console.WriteLine("The result is {0}", result);
        }
        static void Mul(int operand1, int operand2)
        {
            int result = operand1 * operand2;
            Console.WriteLine("The result is {0}", result);
        }
        static void Div(int operand1, int operand2)
        {
            int result = operand1 / operand2;
            Console.WriteLine("The result is {0}", result);
        }
        #endregion
        static void Main(string[] args)
        {
            //1
            Hello();
            //2
            Hello1("Hello1");
            //3
            int sum = Add(2, 24);
            Console.WriteLine(sum);
            //4
            int sum1 = Add1();
            Console.WriteLine(sum1);
            //5
            string phrase = MakeConcatenation("Viktor");
            Console.WriteLine(phrase);

            // Home tasks
            //6
            string numA = Console.ReadLine();
            int num1 = Int32.Parse(numA);
            string numB = Console.ReadLine();
            int num2 = Int32.Parse(numB);
            string numC = Console.ReadLine();
            int num3 = Int32.Parse(numC);

            int res = Calculate(num1, num2, num3);
            Console.WriteLine("Arithmetic mean is {0}", res);

            //7
            Console.WriteLine("Please enter two numbers");

        LabelOperation:
            try
            {
                Console.Write("Number 1: ");
                string numberOne = Console.ReadLine();
                int number1 = Int32.Parse(numberOne);
                Console.Write("Number 2: ");
                string numberTwo = Console.ReadLine();
                int number2 = Int32.Parse(numberTwo);

                Console.WriteLine("Enter operation");
                Console.Write("Operations (-; +; /; *): ");

                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Add(number1, number2);
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            Div(number1, number2);
                        }
                        else
                        {
                            Console.WriteLine("You cannot divide by zero, please try again");
                            goto LabelOperation;
                        }
                        break;
                    case "*":
                        Mul(number1, number2);
                        break;
                    case "-":
                        Sub(number1, number2);
                        break;
                    default:
                        Console.WriteLine("You entered wrong operation, please try again");
                        goto LabelOperation;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("It's NOT a number!!!!");
                goto LabelOperation;
            }


        }
    }
}
