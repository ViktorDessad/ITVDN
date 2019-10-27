using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Properties
{
    class MyClass
    {
        private string field = null;

        public string Property
        {
            set
            {
                if (value == "good")
                {
                    field = value;
                }
                else if (value == "bad")
                {
                    field = value;
                }
                else
                {
                    field = value;
                }
            }

            get
            {
                if (field == null)
                {
                    return "This field is empty";
                }
                else if (field == "good")
                {
                    return field.ToUpper() + "!";
                }
                else if (field == "bad")
                {
                    return field.ToLower() + "!";
                }
                else
                {
                    return field;
                }

            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Console.Write("Enter a word: ");
            my.Property = Console.ReadLine();
            Console.WriteLine(my.Property);
	
        }
    }
}
