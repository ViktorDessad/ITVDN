using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_009
{
    class ClassFigure
    {
        //Создание массива значений типа Point
        ClassPoint[] point;

        //Свойство для отображения типа фигуры 
        public string Type { get; }

        //Метод вычисления длинны сторони
        double LengthSide(ClassPoint A, ClassPoint B)
        {
            //Возвращает квадратный корень из суммы разниц координат возвышенных в квадрат  =√((Y.b - Y.a)^2 + (X.b - X.a)^2)
            return Math.Sqrt(Math.Pow((B.A - A.A), 2) + Math.Pow((B.B - A.B), 2));
        }

        //Метод вычисления периметра фигуры
        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                //Суммируем длину каждой стороны фигуры
                sum += LengthSide(point[i], point[i + 1]);
            }
            //Прибавляем длину последней стороны
            sum += LengthSide(point[point.Length - 1], point[0]);
            Console.Write(sum);
        }
        //Пользовательский конструктор
        public ClassFigure(ClassPoint p1, ClassPoint p2, ClassPoint p3)
        {
            //Инициализация полей.
            point = new ClassPoint[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            Type = "Triangle";
        }

        //Перегрузка пользовательского конструктора
        public ClassFigure(ClassPoint p1, ClassPoint p2, ClassPoint p3, ClassPoint p4)
        {
            //Инициализация полей.
            point = new ClassPoint[4];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            Type = "Tetragon";
        }
        //Перегрузка пользовательского конструктора
        public ClassFigure(ClassPoint p1, ClassPoint p2, ClassPoint p3, ClassPoint p4, ClassPoint p5)
        {
            //Инициализация полей.
            point = new ClassPoint[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            point[4] = p5;
            Type = "Pentagon";
        }
    }
}
