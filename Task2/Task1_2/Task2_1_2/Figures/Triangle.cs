using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Triangle:Figure
    {
        public Point FirstPoint { get; private set; }
        public Point SecondPoint { get; private set; }
        public Point ThirdPoint { get; private set; }

        protected List<Line> _lines = new List<Line>();

        public Triangle(Point a, Point b, Point c)
        {
            FirstPoint = a;
            FirstPoint = b;
            FirstPoint = c;
            _lines = new List<Line>() { new Line(a, b), new Line(b, c), new Line(c, a) };
        }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            FirstPoint = new Point(x1, y1);
            SecondPoint = new Point(x2, y2);
            ThirdPoint = new Point(x3, y3);
            _lines = new List<Line> { new Line(x1, y1, x2, y2), new Line(x2, y2, x3, y3), new Line(x3, y3, x1, y1) };
        }
        public override double Square
        {
            get
            {
                double a = _lines[0].Length;
                double b = _lines[1].Length;
                double c = _lines[2].Length;
                double p = (a + b + c) / 2.0;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override double Length => _lines[0].Length + _lines[1].Length + _lines[2].Length;

        public override void GetInfo()
        {
            Console.WriteLine("Triangle. First point: {0}, Second point: {1}, Third point: {2}. Square: {3}. Perimeter:{4}",
                FirstPoint, SecondPoint, ThirdPoint, Square, Length);
        }
    }
} 
