using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Constructors
{
    class Point
    {
        private int x, y;
        private string name;
        private double z;
        private int a, b, c;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        public double Z
        {
            get { return z; }
        }

        public int A
        {
            get {return a;}
        }

        public int B
        {
            get {return b;}
        }

        public int C
        {
            get {return c;}
        }
        

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(string name)
            : this(100, 200)
        {
            this.name = name;
        }

        public Point (double z)
            : this("Viktor")
        {
            this.z = z;
        }

        public Point (int a, int b, int c)
            : this(99.00)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1,2,3);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("x - {0}, y - {1}",point.X,point.Y);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("name - {0}",point.Name);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("z - {0}", point.Z);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("a - {0}, b - {1}, c - {2}",point.A,point.B,point.C);
            Console.ReadKey();
        }
    }
}
