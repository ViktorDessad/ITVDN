using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static double ConvertCurrency (double currency, double amount)
        {
            double result = currency * amount;
            return result;
            
        }

        static void Main(string[] args)
        {
            Console.Write("Enter user name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}", userName);

            Currency:
            Console.Write("Enter currency(D - dollar, E - euro, G - grivna): ");
            char currency = Convert.ToChar(Console.ReadLine());

            if (currency == 'D' || currency == 'E' || currency == 'G' )
            {
                switch (currency)
                {
                    case 'D':
                        Console.WriteLine("Ammount: ");
                        double dollarAmmount = Convert.ToDouble(Console.ReadLine());
                        double euro = ConvertCurrency(0.93, dollarAmmount);
                        double grivna = ConvertCurrency(25.2, dollarAmmount);
                        Console.WriteLine("Dollar = {0} \nEuro = {1}, Grivna = {2}", dollarAmmount, euro, grivna);
                        break;
                    case 'E':
                        Console.WriteLine("Ammount: ");
                        double euroAmmount = Convert.ToDouble(Console.ReadLine());
                        double dollar = ConvertCurrency(1.11, euroAmmount);
                        double grivna1 = ConvertCurrency(28.22, euroAmmount);
                        Console.WriteLine("Euro = {0} \nDollar = {1}, Grivna = {2}", euroAmmount, dollar, grivna1);
                        break;
                    case 'G':
                        Console.WriteLine("Ammount: ");
                        double grivnaAmmount = Convert.ToDouble(Console.ReadLine());
                        double dollar1 = ConvertCurrency(0.041, grivnaAmmount);
                        double euro1 = ConvertCurrency(0.038, grivnaAmmount);
                        Console.WriteLine("Grivna = {0} \nEuro = {1}, Dollar = {2}", grivnaAmmount, euro1, dollar1);
                        break;

                }
            }
            else
            {
                Console.WriteLine("This currency doesn't exist at this moment, please try again");
                goto Currency;
            }
            

        }
    }
}
