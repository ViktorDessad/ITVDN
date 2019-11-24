using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_base.Method
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            //Upcast
            BaseClass baseClass = derivedClass;
            baseClass.Method();

            //DownCast
            DerivedClass derivedClass1 = (DerivedClass)baseClass;
            derivedClass1.Method();
        }
    }
}
