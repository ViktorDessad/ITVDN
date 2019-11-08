using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Association
{

    class Field
    {
        public void MethodField()
        {
            Console.WriteLine("Method Field");
        }

        public Field()
        {
            Console.WriteLine("Method Field");
        }
    }

    class CallField
    {
        private Field field;

        public void Field()
        {
            field = new Field();
        }

        public void Field2()
        {
            field.MethodField();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            CallField callField = new CallField();
            callField.Field();
            callField.Field2();

        }
    }
}
