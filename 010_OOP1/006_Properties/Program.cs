using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Properties
{
    class Str 
    {
        private string str = null;

        public string Property
        {
            set
            {               
                    if (value == "fool")
                    {
                       Console.WriteLine("This is a bad world, try once again");
                    }
                    else
                    {                   
                        str = value;
                    }    
            }

            get
            {
                if (str == "Hello")
	            {
                    return str;
	            }
                else if (str == " ")
            	{
                    return "Space";
	            }
                else if (str == "Hello Viktor")
                {
                    return str.ToUpper();
                }
                else
                {
                    return "null";
                }

            }
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
         Str @string = new Str();
            Console.Write("Enter a word: ");
            @string.Property = Console.ReadLine();
            Console.WriteLine(@string.Property);
            Console.ReadKey();
        }
    }
}
