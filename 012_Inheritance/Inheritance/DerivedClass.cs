using System;
namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            protectedField = "Protected from derived class";
            publicField = "Public from derived class";
        }

        public void MethodFromDerived()
        {
            Console.WriteLine(protectedField);
        }
        
       
    }
}
