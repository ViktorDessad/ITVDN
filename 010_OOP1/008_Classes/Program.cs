using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                if (value == "bad")
                {
                    field = value;
                }
                else if (value == "good")
                {
                    field = value;
                }
                else if (value != "bad" || value != "good")
                {
                    field = value;
                }
            }

            get
            {
                return field;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Console.WriteLine("Enter a word: ");
            my.Field = Console.ReadLine();

            if (my.Field == "good")
            {
                Console.WriteLine($"Hello Viktor! you are a {my.Field} boy");
            }
            else if (my.Field == "bad")
            {
                Console.WriteLine($"Hello Viktor Sheresh you are a {my.Field} boy");
            }
            else
            {
                Console.WriteLine($"This word -\"{my.Field}\"- doesn't exist at this moment");
            }

                Console.ReadKey();
        }
    }
}
