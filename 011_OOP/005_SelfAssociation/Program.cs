using System;

namespace _005_SelfAssociation
{
    class MyClass1
    {
        public int Field { get; } = 10;

        MyClass1 my;
        public MyClass1(int x)
        {
            my = new MyClass1(x);
        }

        public void My()
        {
            Console.WriteLine(my.Field);
        }
    }

    class MyClass2
    {
        MyClass1 my;

        public void MyMethod(int x)
        {
            my = new MyClass1(x);
            my.My();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            MyClass2 my = new MyClass2();
            my.MyMethod(1);
            // Process is terminated due to StackOverflowException.
        }
    }
}
