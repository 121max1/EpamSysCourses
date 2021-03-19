using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Rectangle : SquareFig
    {
        public Rectangle(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {
        }

        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }

        public override double Square => _lines[0].Length * _lines[1].Length;

        public override double Length => 2*(_lines[0].Length + _lines[1].Length);

        public override void GetInfo()
        {
            base.GetInfo();
        }
    }
}
