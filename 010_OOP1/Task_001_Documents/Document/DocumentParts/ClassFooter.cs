using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    class ClassFooter
    {
        private string footerName;

        public string Footer
        {
            private get 
            {
                if (footerName !=null)
                {
                    return footerName;
                }
                else
                {
                    return "The footer is empty";
                }
            }

            set
            {
                footerName = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Footer);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
