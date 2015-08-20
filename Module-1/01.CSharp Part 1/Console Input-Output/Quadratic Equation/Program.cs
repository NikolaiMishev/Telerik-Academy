//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it
//(prints its real roots).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter A:");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter B:");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Enter C:");
        double numberC = double.Parse(Console.ReadLine());

        double determinant = Math.Sqrt((numberB * numberB) - 4 * numberA * numberC);
       
        double xOne = (-numberB - determinant) / (2 * numberA);

        double xTwo = (-numberB + determinant) / (2 * numberA);

        if (numberA + numberB <= numberC)
        {
            Console.WriteLine("There are no real roots");
        }
        else
        Console.WriteLine("X1={0} X2={1}",xOne,xTwo);

       
    }


}