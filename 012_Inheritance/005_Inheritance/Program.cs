using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            //UpCast
            // Приведение к базовому типу, все методы и поля из производного
            // класса не будут доступны в базовом классе
            BaseClass baseClass = derivedClass;
            baseClass.Method();

            //DownCast
            //DownCast - невозможен без предварительного UpCast
            DerivedClass derivedClass1 = (DerivedClass)baseClass;
            derivedClass1.Method();


            
        }
    }
}
