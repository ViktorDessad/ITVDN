using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_006
{
    class Invoice
    {
        private readonly int account = 1991;
        private readonly string customer = "Viktor";
        private readonly string provider = "Microsoft";

        private string article;
        private int quantity;

        public Invoice()
        {
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = customer;
        }

        public void Vat(string article, int quantity, double sPrice, double vat)
        {
            this.article = article;
            this.quantity = quantity;

            double fullPrice = quantity * sPrice * vat;

            Console.WriteLine($"account - {account}, customer - {customer}, provider - {provider}");
            Console.WriteLine($"(With VAT) " +
                $"Article - {this.article}, Quantity - {this.quantity}, " +
                $"Standart price {sPrice}, full price {fullPrice}");
        }
        public void Vat(string article, int quantity, double sPrice)
        {
            this.article = article;
            this.quantity = quantity;

            double fullPrice = quantity * sPrice;

            Console.WriteLine($"account - {account}, customer - {customer}, provider - {provider}");
            Console.WriteLine($"(Without VAT) " +
                $"Article - {this.article}, Quantity - {this.quantity}, " +
                $"Standart price {sPrice}, full price {fullPrice}");
        }

    }
}
