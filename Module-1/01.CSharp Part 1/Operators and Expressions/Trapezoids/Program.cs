//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter side A:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side B:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the height H:");
        double h = double.Parse(Console.ReadLine());
       
        double area;

        area = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapsezoid is:" + area);

    }
}