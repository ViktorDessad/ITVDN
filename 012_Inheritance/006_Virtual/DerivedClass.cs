using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Virtual
{
    class DerivedClass : BaseClass
    {
        public override void Method(int a = 10, int b = 20)
        {

            Console.WriteLine($"From Derived = {a + b}");
        }

        public override int Method1(int a = 1000, int b = 2)
        {
            return a + b;
        }
    }
}
