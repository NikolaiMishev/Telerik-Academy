//Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        int startIndex = 0, currentSum = 0;
        int bestStart = 0, bestEnd = 0, bestSum = int.MinValue;

        Console.WriteLine("Enter a number for N:");
        int N = int.Parse(Console.ReadLine());

        int[] nums = new int[N];
        Console.WriteLine("Enter {0} number(s) to array:", N);
        for (int i = 0; i < N; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += nums[i];

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }
        for (int i = bestStart; i <= bestEnd; i++)
        {
            Console.Write(i != bestEnd ? nums[i] + ", " : nums[i] + "\n");
        }
    }
}