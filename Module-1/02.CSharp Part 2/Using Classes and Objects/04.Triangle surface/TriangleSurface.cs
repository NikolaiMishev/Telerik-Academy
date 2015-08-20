//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Calculate the surface of a triangle by:");
        Console.WriteLine("\n1:Given side and an altitude to it.");
        Console.WriteLine("\n2:Given three sides.");
        Console.WriteLine("\n3:Given two side and the angle between them.");
        Console.Write("\nYour choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                GetSurfaceBySideAndAltitude();
                break;
            case 2:
                GetSurfaceByTreeSides();
                break;
            case 3:
                GetSurfaceByTwoSidesAndAngle();
                break;
            default:
                Console.WriteLine("Invalid input!!!");
                break;
        }

    }

    private static void GetSurfaceByTwoSidesAndAngle()
    {
        Console.WriteLine();
        Console.Write("Enter side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter the angle between the sides:");
        double angle = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The surface of the triangle is--->{0}<---", (Math.Sin(angle*Math.PI/180)*sideA*sideB)*1/2);
    }

    private static void GetSurfaceByTreeSides()
    {
        Console.WriteLine();
        Console.Write("Enter side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter side C: ");
        double sideC = double.Parse(Console.ReadLine());

        double p = (sideA+sideB+sideC)/2;

        Console.WriteLine("The surface of the triangle is--->{0}<---",Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC)));
    }

    private static void GetSurfaceBySideAndAltitude()
    {
        Console.Write("Enter the length of one of the sides: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter the altitude to it: ");
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("The surface of the triangle is--->{0}<---", (double)(side*altitude)/2);
    }
}
