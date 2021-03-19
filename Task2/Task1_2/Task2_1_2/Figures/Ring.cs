using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Ring : Figure
    {
        public Circle InnerCircle  { get; private set; }
        public Circle OuterCircle { get; private set; }

        public Ring(double innerCircleX, double innerCircleY,double innerCircleRadius, double outerCircleRadius)
        {
            InnerCircle = new Circle(innerCircleX, innerCircleY, innerCircleRadius);
            OuterCircle = new Circle(innerCircleX, innerCircleY, outerCircleRadius);
        }

        public override double Square => OuterCircle.Square - InnerCircle.Radius;

        public override double Length => InnerCircle.Length + OuterCircle.Radius;

        public override void GetInfo()
        {
            Console.WriteLine("Ring. Square: {0}, Length: {1}", Square, Length);
            Console.WriteLine("InnerCircle. Centre: {0}. Radius: {1}", InnerCircle.Centre, InnerCircle.Radius);
            Console.WriteLine("OuterCircle. Centre: {0}. Radius: {1}", OuterCircle.Centre, OuterCircle.Radius);
           
        }
    }
}
