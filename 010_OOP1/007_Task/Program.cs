using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Task
{
    class Rectangle
    {
        public double Side1 { get; }
        public double Side2 { get; }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double AreaCalculator ()
        {
            return Side1 * Side2;    
        }

        public double PerimeterCalculator ()
        {
            return Side1 + Side2;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10.5, 20.23);
            double area = rectangle.AreaCalculator();
            double perimeter = rectangle.PerimeterCalculator();
            Console.WriteLine($"Area = {area} and Perimeter = {perimeter}");
        }
    }
}
