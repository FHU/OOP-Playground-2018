using System;
namespace OOPPlayground
{
    public class Circle: Shape
    {
        public Circle()
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get;
            set;
        }

        public override double Area {
            get {
                return Math.PI * Radius * Radius;
            }
        } 

        public override double Perimeter {
            get {
                return 0;
            }
        }

    }
}
