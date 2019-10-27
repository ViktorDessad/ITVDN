using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Properties
{
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;

        public double PI
        {
            set
            {
                pi = value;
            }
        }

        public double E
        {
            get
            {
                return e;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Constants constants = new Constants();
            //Console.WriteLine(constants.PI); // WhiteOnly
            constants.PI = 213.231D;
            //constants.E = 123.D; // ReadOnly
            Console.WriteLine(constants.E);


        }
    }
}
