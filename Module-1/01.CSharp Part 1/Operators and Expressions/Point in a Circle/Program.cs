//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the X:");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter the Y:");
        double pointY = double.Parse(Console.ReadLine());

        bool IsThePointInCircle = (pointX - 0) * (pointX - 0) + (pointY - 0) * (pointY - 0) <= 2 * 2;

        if(IsThePointInCircle)
        {
            Console.WriteLine("The point IS in the circle");
        }
        else
            Console.WriteLine("The point is NOT in the circle");

    }
}
