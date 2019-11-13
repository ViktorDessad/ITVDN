using System;

namespace Less02_task02
{
    public class MyClass
    {
        public bool IsLuckyTicket(string ticket)
        {
            if (ticket.Length != 6)
                return false;
            int number;
            if (!Int32.TryParse(ticket, out number))
                return false;
            return (SumDigits(number / 1000) == SumDigits(number % 1000));
        }
        public static int SumDigits(int number)
        {
            string s = number.ToString();
            if (s.Length == 1)
                s = s.Insert(0, "00");
            else if (s.Length == 2)
                s = s.Insert(0, "0");
            return Convert.ToInt32(s[0].ToString()) + Convert.ToInt32(s[1].ToString()) + Convert.ToInt32(s[2].ToString());
        }
    }
    class Program
    {
         static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Console.WriteLine(my.IsLuckyTicket("123007"));
            Console.WriteLine(my.IsLuckyTicket("123006"));            
        }
    }
}
