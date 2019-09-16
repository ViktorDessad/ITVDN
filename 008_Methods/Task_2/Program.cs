using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void ToPayDebt(string payerName, double payerDebt, double payerAmount)
        {
            double diff = payerAmount - payerDebt;
            if (payerDebt > payerAmount)
            {
                Console.WriteLine($"Dear {payerName}, your balance a this moment {diff}.");
                Console.WriteLine($"You need make a deposit for {Math.Abs(diff)}");
            }

            else if (payerAmount >= payerDebt)
            {
                if (payerAmount > payerDebt)
                {
                    Console.WriteLine($"Dear {payerName}, your balance a this moment {diff}.");
                    Console.WriteLine("Congratulation, your fully paid your debt");
                }

                else if (payerAmount == payerDebt)
                {
                    Console.WriteLine($"Dear {payerName}, your balance a this moment zero - {diff}.");
                    Console.WriteLine("Congratulation, your fully paid your debt");
                }

            }

        }


        static void Main(string[] args)
        {
            Console.Write("Enter payer name: ");
            string payerName = Console.ReadLine();
            Console.Write("Enter payer debt: ");
            double payerDebt = Double.Parse(Console.ReadLine());
            Console.Write("Payer amount: ");
            double payerAmmount = Double.Parse(Console.ReadLine());
            ToPayDebt(payerName, payerDebt, payerAmmount);
            

        }
    }
}
