using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulation
{
    class MyClass
    {
        MyClass my = null;

        private void MyMethod()
        {
            Console.WriteLine("Hello");
        }

        public void CallMethod()
        {
            my = new MyClass();


            my.MyMethod();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
            
        }
    }
}
