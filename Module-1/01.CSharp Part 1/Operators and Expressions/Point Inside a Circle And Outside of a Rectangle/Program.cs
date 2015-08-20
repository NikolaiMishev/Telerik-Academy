//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the X:");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter the Y:");
        double pointY = double.Parse(Console.ReadLine());

        bool isThePointInCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= 1.5 * 1.5;


        bool isThePointInRectangle = (pointY <= 1 && pointY >= -1) && (pointX <= 5 && pointX > -1);

        if (isThePointInCircle && !isThePointInRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

