using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Classes
{
    class MyClass
    {
        public void CallingMethod()
        {
            Console.WriteLine("This class calling from another class");
        }
    }

    class MyClass2
    {
        public void Calling(MyClass my)
        {
            my.CallingMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass2 my2 = new MyClass2();
            my2.Calling(my);
        }
    }
}
