using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inheritance_constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedNumber;

        //public DerivedClass()
        //{

        //}

        public DerivedClass(int number1, int number2)
            : base(number1)
        {
            derivedNumber = number2;
        }
    }
}
