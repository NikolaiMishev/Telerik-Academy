//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter N:[1<n<100]: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K:[1<k<n]: ");
        int k = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;

        for(int i = 1; i <= n ; i++)
        {
            if (i <= k)
            {
                factorialK *= i;
            }

            factorialN *= i;
         
        }
        Console.WriteLine(factorialN/factorialK);



    }
}