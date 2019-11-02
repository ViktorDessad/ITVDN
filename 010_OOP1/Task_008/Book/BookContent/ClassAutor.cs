using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_008.BookContent
{
    class ClassAutor
    {
        private string autor;

        public string AutorProperty
        {
            private get
            {
                if (string.IsNullOrEmpty(autor))
                    return "This string is empty";
                else
                    return autor;
            }

            set
            {
                autor = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Autor = {autor}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
            

    }
}
