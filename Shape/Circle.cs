using System;
namespace Shape
{
    public class Circle : IShape, IColorable
    {
        public Circle()
        {
        }

        public double Radius {
            get; 
            set;
        }

        public double Area {
            get {
                return Math.PI * Radius * Radius;
            }
        }

        public double Perimeter => 2 * Math.PI * Radius;

        public Color Color { get; set; }
    }
}
