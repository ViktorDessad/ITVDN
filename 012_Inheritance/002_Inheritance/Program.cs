using System;

namespace _002_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass();
            baseClass.Show();
            Console.WriteLine(new string('-', 50));
            derivedClass.Show();  
        }
    }
}
