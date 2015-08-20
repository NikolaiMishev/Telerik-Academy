//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the bit you want to see:");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int result;

        result = number & mask;
        Console.WriteLine("The value of the 3rd bit is:" + (result >> p));



    }
}