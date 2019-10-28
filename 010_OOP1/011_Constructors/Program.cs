using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Constructors
{
    class Point
    {
        // Fields
        private int x, y;

        // Properties
        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public Point()
        {
            Console.WriteLine("Parameterless constructor");
        }

        public Point(int x, int y)
        {
            Console.WriteLine("Constructor with parameters");
            

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Console.WriteLine($"x - {point.X}, y - {point.Y} = parameterless constructor");
            Console.WriteLine(new string('-', 60));
            Point point1 = new Point(1, 2);
            Console.WriteLine($"x - {point1.X}, y - {point1.Y} = constructor with parameters");
            Console.ReadKey();

        }
    }
}
