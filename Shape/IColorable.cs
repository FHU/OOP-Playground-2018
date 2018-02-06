using System;
namespace Shape
{
    public enum Color {
        Red, Orange, Yellow, Green, Blue, Indigo, Violet, Black, White
    }

    public interface IColorable
    {
        Color Color { get; }
    }
}
