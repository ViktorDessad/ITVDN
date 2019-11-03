using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_009
{
    class ClassPoint
    {
        private int a;
        private int b;
        private string name;

        public int A { get { return a; } }
        public int B { get { return b; } }
        public string Name { get { return name; } }

        public ClassPoint (int a, int b, string name)
        {
            this.a = a;
            this.b = b;
            this.name = name;
        }
    }
}
