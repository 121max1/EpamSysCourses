using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Circle:Figure
    {
        public Point Centre { get; set; }
        public double Radius { get; private set; }
        public Circle(double x, double y, double radius)
        {
            Centre = new Point(x, y);
            Radius = radius;
        }
        public override double Length => 2 * Math.PI * Radius;

        public override double Square => 2 * Math.PI * Radius * Radius;

        public override void GetInfo()
        {
            Console.WriteLine("Circle. Centre: {0}. Radius: {1}", Centre, Radius);
        }
    }

}
