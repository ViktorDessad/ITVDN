using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inheritance
{
    class BaseClass
    {
        public string field_1 = "PublicBaseClass";
        protected string field_2 = "ProtectedBaseClass";
        private string field_3 = "PrivateBaseClass";

        public void Show()
        {
            Console.WriteLine(field_1);
            Console.WriteLine(field_2);
            Console.WriteLine(field_3);
        }
    }
}
