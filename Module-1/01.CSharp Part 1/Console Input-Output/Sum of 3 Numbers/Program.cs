//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number A:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number B:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number C:");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of those number is:{0}",a+b+c);
    }
}