using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Properties
{
    class MyClass
    {
        private string field = null;
        // Название поля field должно совпадать с именем свойства данного поля Field 
        // и разница только в заглавной букве, она должна быть большой - Field
        public string Field // Открытое строковое свойство Field
        {
            set
            {
                field = value; // Method-mutator
            }
            get
            {
                return field; // Method-accessor
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            // Обращение к свойству Field со следующим присвоением полю ему значение 
            instance.Field = "Hello World"; // Method-mutator 

            string @string = instance.Field; // Method-accessor
            Console.WriteLine(@string);
            Console.ReadKey();
        }
    }
}
