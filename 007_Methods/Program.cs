using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Methods
{
    class Program
    {

        #region 1. This method does not take a value, and does not return a value
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        #endregion

        #region 2. This method take a value, but does not return he just execute this
        static void Hello1(string word)
        {
            Console.WriteLine(word);
        }
        #endregion

        #region 3. This method take a value and returned it
        static int Add (int oper1, int oper2)
        {
            return oper1 + oper2;
        }
        #endregion

        #region 4. This method does not take a value, but he returned it

        static int Add1()
        {
            int a = 21;
            int b = 3;
            int sum = a + b;
            return sum;
        }
        #endregion
        static void Main(string[] args)
        {
            //1
            Hello();
            //2
            Hello1("Hello1");
            //3
            int sum = Add(2,24);
            Console.WriteLine(sum);
            //4
            int sum1 = Add1();
            Console.WriteLine(sum1);

        }
    }
}
