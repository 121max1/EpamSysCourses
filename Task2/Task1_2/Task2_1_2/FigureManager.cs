using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public static class FigureManager
    {
        public static Circle CreateCircle(double x, double y, double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть отрицательным");
            }
            else
            {
                return new Circle(x, y, radius);
            }
        }
        public static Ring CreateRing(double x, double y, double radius1, double radius2)
        {
            if(radius1>radius2)
            {
                throw new Exception("Радиус внешней окружности не может быть меньше радиуса внутренней окружности");
            }
            else
            {
                return new Ring(x, y, radius1, radius2);
            }
        }
        public static Line CreateLine(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                throw new Exception("Точки начала и конца прямой не могут совпадать");
            }
            else
            {
                return new Line(x1, y1, x2, y2);
            }
        }
        private static bool IsSquareOrRectanleAngles(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            Line a = CreateLine(x1, y1, x2, y2);
            Line b = CreateLine(x2, y2, x3, y3);
            Line c = CreateLine(x3, y3, x4, y4);
            Line d = CreateLine(x4, y4, x1, y1);
            Line diag1 = new Line(x1, y1, x3, y3);
            Line diag2 = new Line(x4, y4, x2, y2);
            if (diag1.Length == Math.Sqrt(Math.Pow(a.Length, 2) + Math.Pow(b.Length, 2)) &&
                diag2.Length == Math.Sqrt(Math.Pow(c.Length, 2) + Math.Pow(d.Length, 2)))
            {
                return true;
            }
            return false;
        }
        public static Rectangle CreateRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
           
            if (!IsSquareOrRectanleAngles(x1,y1,x2,y2,x3,y3,x4,y4))
            {
                throw new Exception("Это не прямоугольник.");
            }
            else
            {
                return new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);
            }
        }
        public static SquareFig CreateSquare(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            Line a = CreateLine(x1, y1, x2, y2);
            Line b = CreateLine(x2, y2, x3, y3);
            Line c = CreateLine(x3, y3, x4, y4);
            Line d = CreateLine(x4, y4, x1, y1);
            if (!IsSquareOrRectanleAngles(x1, y1, x2, y2, x3, y3, x4, y4) && a.Length != b.Length && b.Length != c.Length && d.Length!=a.Length)
            {
                throw new Exception("Это не квадрат.");
            }
            else
            {
                return new SquareFig(x1, y1, x2, y2, x3, y3, x4, y4);
            }
        }
        public static Triangle CreateTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Line a = CreateLine(x1, y1, x2, y2);
            Line b = CreateLine(x2, y2, x3, y3);
            Line c = CreateLine(x3, y3, x1, y1);
            if(c.Length<a.Length+b.Length && a.Length<b.Length+c.Length+a.Length && b.Length<a.Length+c.Length)
            {
                return new Triangle(x1, y1, x2, y2, x3, y3);
            }
            else
            {
                throw new Exception("Это не треугольник");
            }
        }
    }
}
