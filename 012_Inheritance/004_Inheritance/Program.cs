using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            instance.field_1 = 1;
            instance.field_2 = 2;
            instance.field_3 = 3;

            instance.field_4 = 4;
            instance.field_5 = 5;

            //Приведение экземпляра класса DerivedClass к базовому типу BaseClass
            BaseClass newInstance = (BaseClass)instance; //UpCast

            Console.WriteLine(newInstance.field_1);
            Console.WriteLine(newInstance.field_2);
            Console.WriteLine(newInstance.field_3);

            // Данные поля field_4 и field_5 не будут доступны из производнного             
            // класса после приведение к базовому типу
            //Console.WriteLine(newInstance.field_4);
            //Console.WriteLine(newInstance.field_5);

            Console.WriteLine("Instance id (HashCode) - {0}", instance.GetHashCode());
            Console.WriteLine("newInstance id (HashCode) - {0}", newInstance.GetHashCode());

        }
    }
}
