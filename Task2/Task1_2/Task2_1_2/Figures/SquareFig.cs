using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class SquareFig : Triangle
    {
        public Point FourthPoint { get; private set; }

        private List<Line> _lines = new List<Line>();

        public SquareFig(Point a, Point b, Point c, Point d):base(a,b,c)
        {
            FourthPoint = d;
            _lines = new List<Line>() { new Line(a, b), new Line(b, c), new Line(c, d), new Line(d,a)};
        }

        public SquareFig(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
            :base(x1,y1,x2,y2,x3,y3)
        {
            FourthPoint = new Point(x4, y4);
            _lines = new List<Line> { new Line(x1, y1, x2, y2), new Line(x2, y2, x3, y3), new Line(x3, y3, x4, y4), new Line(x4,y4,x1,y1) };

        }

        public override double Square => Math.Pow(_lines[0].Length, 2);

        public override double Length => _lines[0].Length * 4;

        public override void GetInfo()
        {
            Console.WriteLine("Square. First point: {0}, Second point: {1}, Third point: {2}, Fourth Point: {3}. Square: {4}. Perimeter:{5}",
                FirstPoint, SecondPoint, ThirdPoint, FourthPoint, Square, Length);
        }
    }
}
