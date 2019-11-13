using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowExeption
{
    class MyClass
    {
        public MyClass()
        {
            MyClass field = new MyClass();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1");
            MyClass inst = new MyClass();
            Console.Write("2");
            Console.ReadKey();
        }
    }
}
