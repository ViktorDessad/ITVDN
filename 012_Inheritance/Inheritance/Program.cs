using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass();
            Console.WriteLine(baseClass.publicField);
            Console.WriteLine(derivedClass.publicField);
            derivedClass.MethodFromDerived();
            baseClass.MethodFromBase();
            Console.WriteLine(baseClass.MethodPrivateField());
        }
    }
}
