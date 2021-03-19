using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Line:Figure
    {
        public Point FirstPoint { get; private set; }
        public Point SecondPoint { get; private set; }

        public override double Square => 0;

        public override double Length => Math.Sqrt(Math.Pow((FirstPoint.X - SecondPoint.X), 2) 
                                                 + Math.Pow((FirstPoint.Y - SecondPoint.Y), 2));  

        public Line(double x1, double y1, double x2, double y2)
        {
            FirstPoint = new Point(x1, y1);
            SecondPoint = new Point(x2, y2);
        }

        public Line(Point a, Point b)
        {
            FirstPoint = a;
            SecondPoint = b;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Line.First point: {0}, Second point: {1}, Length: {2}", FirstPoint, SecondPoint, Length);
        }
    }
}
