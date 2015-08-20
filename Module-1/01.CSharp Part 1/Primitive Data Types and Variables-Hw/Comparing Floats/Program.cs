//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter number a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number b:");
        double b = Convert.ToDouble(Console.ReadLine());
        double eps = 0.000001;
        bool check = Math.Abs(a - b) < eps;
        if (check)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The numbers ARE equal!!!");
        }
        else
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The numbers are NOT equal!!!");
            Console.ForegroundColor = ConsoleColor.White;
    }
}

