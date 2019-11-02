using System;

namespace Task_005
{
    class Test
    {
        public int a = 99;
        public string b = "C#";
        public double c = Math.PI;

        public Test()
        {

        }

        public Test(int a, string b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void VoidMethod()
        {
            Console.WriteLine(a);
        }

        public string StringMethod()
        {
            return b;
        }

        public double DoubleMethod()
        {
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(1099, "Hello Viktor", 3.14);
            Test test2 = new Test();
            test.VoidMethod();
            string str = test.StringMethod();
            double dbl = test.DoubleMethod();
            Console.WriteLine($"{str},{dbl}");
            Console.WriteLine($"{test2.a},{test2.b}, {test2.c}");
        }
    }
}
