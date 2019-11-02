using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_008
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassBook book = new ClassBook("Viktor Sheresh", "Very good book", "Title");
            book.Show();
            Console.ReadKey();
        }
    }
}
