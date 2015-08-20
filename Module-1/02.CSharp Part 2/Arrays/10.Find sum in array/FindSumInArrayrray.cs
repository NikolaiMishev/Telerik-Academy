//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArrayrray
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter sum S: ");
        int sum = int.Parse(Console.ReadLine());
        Console.WriteLine("Ente {0} numbers to array: ", n);
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] + arr[i + 1] + arr[i + 2] == sum)
            {
                Console.WriteLine(arr[i] + ", " + arr[i+1] + ", " + arr[i+2]);
                break;
            }
        }

    }
}
