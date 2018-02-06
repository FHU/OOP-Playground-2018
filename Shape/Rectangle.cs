using System;
namespace Shape
{
    public class Rectangle: IShape
    {
        public Rectangle()
        {
        }

        public double Length
        {
            get;
            set;
     
        }

        public double Width
        {
            get;
            set;
        }

        public double Area => Length * Width;

        public double Perimeter => 2 * Length + 2 * Width;
    }
}
