using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    class MyClass
    {
        private string name;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                    return "Name is not defined";
                else
                    return name;
            }

            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.Name = "test";
            Console.WriteLine(my.Name);
            Console.ReadKey();
        }
    }
}
