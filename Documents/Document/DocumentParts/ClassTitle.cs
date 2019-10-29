using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    class ClassTitle
    {
        private string titleName;

        public string Title
        {
            get 
            {
                if (titleName !=null)
                {
                    return titleName;
                }
                else
                {
                    return "The title is empty";
                }
            }

            set
            {
                titleName = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
