//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Please enter five digits separated by a space: ");
        string[] allDigits = Console.ReadLine().Split();

        double result = 0;
        double diggit;
        for (int i = 0; i < 5; i++)
        {
            diggit = Convert.ToDouble(allDigits[i]);
            result += diggit;
        }
        Console.WriteLine("The sum is:" + result);
    }
}