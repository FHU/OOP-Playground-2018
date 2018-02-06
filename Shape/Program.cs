using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IShape c = new Circle() { 
                Radius=10
            };


            IShape r = new Rectangle() { 
                Length = 9, 
                Width = 5 
            };

            IShape[] shapes = { c, r };

            foreach (var s in shapes) {
                Console.WriteLine($"Area: {s.Area}  Perimeter: {s.Perimeter}");
            }

            //Console.WriteLine($"Area: {c.Area}  Perimeter: {c.Perimeter}");
            //Console.WriteLine($"Area: {r.Area}  Perimeter: {r.Perimeter}");

        }
    }
}
