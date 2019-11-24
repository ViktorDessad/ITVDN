using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_base.Method
{
    class DerivedClass : BaseClass
    {
        public void Method()
        {
            base.Method();

            //Recursion
            //Method();

            Console.WriteLine("Derived Method");
        }
    }
}
