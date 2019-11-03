using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_009
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание объекта класса Figure и передача конструктору трех объектов класса Point в качестве аргументов.  
            ClassFigure figure = new ClassFigure(new ClassPoint(1, 1,"A"), new ClassPoint(1, 4, "B"), new ClassPoint(4, 4, "C"));

            //Отображение результата выполнения метода Type.
            Console.Write("{0}, P = ", figure.Type);

            //Вызов метода PerimeterCalculator для вычисления периметра фигуры.
            figure.PerimeterCalculator();

            // Delay.
            Console.ReadKey();
        }
    }
}
