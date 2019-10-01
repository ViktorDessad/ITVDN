using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Properties
{
    class MyClass
    {
        private string field = "Hello Viktor";

        public void SetField(string value)
        {
            field = value;
        }
        public string GetField()
        {
            return field;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello World");

            string @string = instance.GetField();

            Console.WriteLine(@string);
            Console.ReadKey();
        }
    }
}
