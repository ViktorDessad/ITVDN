using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass partial = new PartialClass();
            Console.WriteLine(partial.field1);                  //ParialClass1
            Console.WriteLine(partial.Method2(99));             //PartialClass2
            Console.WriteLine(partial.Str = "It's a string");   //PartialClass4
            Console.WriteLine(partial.Str1);                    //PartialClass5
        }
    }
}
