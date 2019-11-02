using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_008.BookContent
{
    class ClassContent
    {
        private string content;

        public string ContentProperty
        {
            private get
            {
                if (string.IsNullOrEmpty(content))
                    return "This string is empty";
                else
                    return content;
            }

            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"content = {content}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
