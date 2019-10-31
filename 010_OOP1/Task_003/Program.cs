﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    class Class1
    {
        private int x;
        private int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Class1(int z)
        {
            x = z;
            y = z;
        }

        public Class1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Class1 Method(Class1 inst1, Class1 inst2)
        {
            return new Class1(inst1.X + inst2.X, inst1.Y + inst2.Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 inst1 = new Class1(2, 3);
            Class1 inst2 = new Class1(5, 7);

            Class1 inst3 = Class1.Method(inst1, inst2);

            Console.WriteLine("X = {0}; Y = {1}", inst3.X, inst3.Y);

            Console.ReadKey();
        }
    }
}
