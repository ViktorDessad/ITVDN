using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Virtual
{
    class BaseClass
    {
        public virtual void Method(int a = 1, int b = 2)
        {
            Console.WriteLine($"From Base = {a + b}");
        }

        public virtual int Method1(int a = 100, int b = 200)
        {
            return a + b;
        }
    }
}
