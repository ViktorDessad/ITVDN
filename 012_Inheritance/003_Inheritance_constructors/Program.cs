using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inheritance_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass(10, 20);
            Console.WriteLine(derivedClass.derivedNumber);
            Console.WriteLine(derivedClass.baseNumber);
            Console.ReadKey();
        }

    }
}
