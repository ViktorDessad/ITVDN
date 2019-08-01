using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PI and E
            double pi = Math.PI;
            double e = Math.E;
            Console.WriteLine($"PI {pi} and E {e}");
            #endregion

            #region String
            string a = "Viktor";
            string b = "Sheresh";
            string c = "Viktorovich";

            Console.WriteLine($"\n{a}");
            Console.WriteLine($"\t{b}");
            Console.WriteLine($"\a{c}");
            #endregion
        }
    }
}
