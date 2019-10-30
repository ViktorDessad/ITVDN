using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    class ClassBody
    {
        private string bodyName;

        public string Body
        {
            private get
            {
                if (bodyName != null)
                {
                    return bodyName;
                }
                else
                {
                    return "The Body is empty";
                }
            }

            set
            {
                bodyName = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Body);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
