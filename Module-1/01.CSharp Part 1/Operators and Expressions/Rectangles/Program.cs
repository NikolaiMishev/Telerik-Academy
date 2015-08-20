//Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the width of rectangle:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of rectangle:");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height;
        double area = width * height;

        Console.WriteLine("The parameter is {0}\nThe area is {1}", perimeter, area);
    }
}
