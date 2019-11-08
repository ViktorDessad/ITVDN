using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_SelfAssociation
{
    class MyClass
    {
        //StackOverflowExeption
        MyClass field;

        public MyClass()
        {            
            Console.WriteLine($"Hello");
            field = new MyClass();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            
        }
    }
}
