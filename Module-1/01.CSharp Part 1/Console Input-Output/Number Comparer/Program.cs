//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number A:");
        double numberA = int.Parse(Console.ReadLine());
        Console.Write("Enter number B:");
        double numberB = double.Parse(Console.ReadLine());

        Console.WriteLine("Number {0} is greater!",numberA>numberB? numberA:numberB);
    }
}
