using System;

namespace _004_Readonly_and_const_fields
{
    class MyClass
    {
        public readonly int field_1 = 10;
        public const int field_2 = 100;

        public int Field_2 { get { return field_2; } }
        public int Field_1 { get { return field_1; } }

        public MyClass()
        {
        }

        public MyClass(int x)
        {
            field_1 = x;
        }  
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass(99);
            MyClass my1 = new MyClass();
            Console.WriteLine(my.field_1);
            Console.WriteLine(my1.Field_2);
            Console.WriteLine(my1.field_1);
        }
    }
}
