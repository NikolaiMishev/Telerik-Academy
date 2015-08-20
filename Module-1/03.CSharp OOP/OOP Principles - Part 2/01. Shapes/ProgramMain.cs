
namespace _01.Shapes
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5.0m, 4.5m),
                new Triangle(3.1m, 5.5m),
                new Square(3.5m)
            };
            Console.WriteLine("Rectangle surface : {0:F2}", shapes[0].CalculateSurface());
            Console.WriteLine("Triangle surface : {0:F2}", shapes[1].CalculateSurface());
            Console.WriteLine("Square surface : {0:F2}", shapes[2].CalculateSurface());
        }
    }
}
