using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Classes
{
    class Buildings
    {
        public int floors;
        public int occupants;
        public int area;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buildings buildings = new Buildings();  
            Buildings buildings1 = buildings;       
            buildings.area = 50;
            buildings1.area = 999;
            Console.WriteLine($"{buildings.area},{buildings1.area}");
        }
    }
}
