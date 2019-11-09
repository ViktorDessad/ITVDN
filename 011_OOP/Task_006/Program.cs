namespace Task_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice_1 = new Invoice(1992, "Andrew", "Amazon");
            Invoice invoice_2 = new Invoice();
            invoice_1.Vat("Book", 10, 10.34);
            System.Console.WriteLine(new string('-', 60));
            invoice_1.Vat("Magazine", 8, 6.45, 0.2);
            System.Console.WriteLine(new string('-', 60));
            invoice_2.Vat("Laptop", 1, 25000);
            System.Console.WriteLine(new string('-',60));
            invoice_2.Vat("Smartphone", 2, 35000.23, 0.25);
        }
    }
}
