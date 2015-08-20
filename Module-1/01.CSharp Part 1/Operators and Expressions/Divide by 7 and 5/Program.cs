//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(number % 100==0&&number%1==0?"True":"False");
    }
}
