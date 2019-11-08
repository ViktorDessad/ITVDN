using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    class Converter
    {
        private double ruble = 0;
        private double euro = 0;
        private double dollar = 0;
        private double grivna = 0;

        public double Grivna
        {
            set
            {
                grivna = value;
            }

        }

        public Converter(double ruble, double euro, double dollar)
        {
            this.ruble = ruble;
            this.euro = euro;
            this.dollar = dollar;
        }

        public void ToRuble()
        {
            Console.WriteLine($"In Ruble = {grivna / ruble}");
        }

        public void ToEuro()
        {
            Console.WriteLine($"In Euro = {grivna / euro}");
        }

        public void ToDollar()
        {
            Console.WriteLine($"In Dollar = {grivna / dollar}");
        }

        public void CurrencyConvert(string currency)
        {
            if (currency == "all")
            {
                ToDollar();
                ToEuro();
                ToRuble();
            }
            else if (currency == "dollar")
            {
                ToDollar();
            }
            else if (currency == "euro")
            {
                ToEuro();
            }
            else if (currency == "ruble")
            {
                ToRuble();
            }
            else
            {
                Console.WriteLine("Error 404");
            }            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(0.64, 28.76, 24.87);
            Console.Write("Enter grivna sum = ");
            converter.Grivna = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chose your currency: ");
            converter.CurrencyConvert(Console.ReadLine());
            Console.ReadKey(); 
        }
    }
}
