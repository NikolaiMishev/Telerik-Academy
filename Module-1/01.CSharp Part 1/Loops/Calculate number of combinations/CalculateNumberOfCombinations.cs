//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example,
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;

class CalculateNumberOfCombinations
{
    static void Main()
    {

        Console.Write("Enter N:[1 < n < 100]: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K:[1 < k < n]: ");
        int k = int.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;
        double factorialNMinusK = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorialK *= i;
            }

            factorialN *= i;

        }
        for (int i = 1; i <= n - k; i++)
        {
            factorialNMinusK *= i;
        }
        Console.WriteLine(factorialN/(factorialK*factorialNMinusK));
    }
}