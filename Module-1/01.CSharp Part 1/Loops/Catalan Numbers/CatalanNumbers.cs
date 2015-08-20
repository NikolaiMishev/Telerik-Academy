//In combinatorics, the Catalan numbers are calculated by the following formula: (2N)! / (N+1)! * N!
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N:[1<=n<=100]: ");
        int n = int.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorial2N = 1;
        double factorialNPlusOne = 1;

        for (int i = n * 2; i >= 1; i--)
        {
            if (i <= n)
            {
                factorialN *= i;
            }
            if (i <= n + 1)
            {
                factorialNPlusOne *= i;
            }
            factorial2N *= i;
        }
        Console.WriteLine(factorial2N/(factorialNPlusOne*factorialN));

    }
}