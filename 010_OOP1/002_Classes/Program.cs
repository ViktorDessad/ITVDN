using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field); ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance1 = new MyClass();
            MyClass instance2 = new MyClass();

            // Обращение к членам класса по сильной ссылке
            instance1.field = 2;
            instance2.field = 5;

            instance1.Method();
            instance2.Method();

            // Обращение к членам класса по слабой ссылке
            new MyClass().Method();
            new MyClass().field = 2;
        }
    }
}
