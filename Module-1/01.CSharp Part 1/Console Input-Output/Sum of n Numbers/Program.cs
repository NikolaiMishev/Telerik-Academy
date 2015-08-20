//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note:
//You may need to use a for-loop.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to sum:");
        int number = int.Parse(Console.ReadLine());

        double counter = 0;

        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter number:");
            counter += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(counter);
    }
}
