//Write a program that finds the most frequent number in an array.

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ente {0} numbers to array: ", n);
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int bestNumber = 0;
        int mostFrequent = 0;
        int counter = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                }
            }
            if (counter > mostFrequent )
            {
                mostFrequent = counter;
                bestNumber = arr[i];
            }
            counter = 0;
        }
        Console.WriteLine(bestNumber + "({0} times)", mostFrequent);


    }
}