using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
    class MyClass
    {
        public string field;

        public void HelloWorld()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass helloWorld = new MyClass();


            helloWorld.field = "Hello World";
            helloWorld.HelloWorld();
            Console.WriteLine(helloWorld.field);
        }
    }
}
