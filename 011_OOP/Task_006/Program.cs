namespace Task_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.Vat("Book", 10, 10.34);
            System.Console.WriteLine(new string('-', 60));
            invoice.Vat("Magazine", 8, 6.45, 0.2);
        }
    }
}
