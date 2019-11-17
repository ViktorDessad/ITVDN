using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{
    class DerivedClass : BaseClass
    {
        public int derivedField;
        public DerivedClass(int number1, int number2)
        {
            baseNumber = number1; // base class field initialization

            derivedField = number2; // derived class field initialization
        }
    }
}
