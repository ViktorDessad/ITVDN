using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_008.BookContent
{
    class ClassTitle
    {
        private string title;

        public string TitleProperty
        {
            private get
            {
                if (string.IsNullOrEmpty(title))
                    return "This string is empty";
                else
                    return title;
            }

            set
            {
                title = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"title = {title}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
