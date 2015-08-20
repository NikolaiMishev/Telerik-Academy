//Write a program that reads the radius r of a circle and prints its 
// perimeter and area formatted with 2 digits after the decimal point.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of a circle:");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("The perimiter of the circle is:{0}", Math.Round((2 * Math.PI * radius),2));
        Console.WriteLine("The area of the circle is:{0}",Math.Round(Math.PI*(radius*radius),2));
        
    }
}
