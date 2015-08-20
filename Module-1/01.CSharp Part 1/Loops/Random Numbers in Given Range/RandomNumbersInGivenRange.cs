//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {

        Console.Write("Enter how many random numbers to print in range min-max:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter Min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter Max: ");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();

         for(int i = 0; i < n; i++)
         {
             int random = rnd.Next(min, max+1);
             Console.WriteLine(random);
         }

    }
}