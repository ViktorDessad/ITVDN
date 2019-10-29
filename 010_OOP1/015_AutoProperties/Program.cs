using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_AutoProperties
{

    class Authors
    {
        public string Name { get; set; }
        public string Book { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Authors authors = new Authors()
            {
                Name = "Jeffrey Richter",
                Book = "CLR via C#"
            };

            Authors authors2 = new Authors
            {
                Name = "Steve McConnel",
                Book = "Code Complete"
            };
            Console.WriteLine("Name - {0}, Book - {1}",authors.Name, authors.Book);
            Console.WriteLine("Name - {0}, Book - {1}",authors2.Name, authors2.Book);
        }
    }
}
