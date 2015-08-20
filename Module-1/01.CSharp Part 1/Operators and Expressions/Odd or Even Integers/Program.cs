//Write an expression that checks if given integer is odd or even.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool even = (number % 2==0);
        Console.WriteLine("Odd?->" + !even);
    }
}
