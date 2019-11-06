using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_PatialMethods.PartialMethods
{
    partial class PartialClass
    {
        //partial void MyMethod();
        partial void MyMethod()
        {
            Console.WriteLine("Hello");
        }

        //partial void PartialMethod();
        partial void PartialMethod()
        {
            Console.WriteLine("Viktor");
        }

        public void PartialMethodCalling()
        {
            MyMethod();
            PartialMethod();
        }
    }
}
