//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int[] arr = new int[num];

        for (int i = 0; i < num; i++)
        {
            arr[i] = i + 1;
        }

        Random random = new Random();

        foreach (int i in arr)
        {
            int randNum = random.Next(0, num);
            int temp = arr[randNum];
            arr[randNum] = arr[0];
            arr[0] = temp;
        }
        Console.WriteLine(String.Join(" ", arr));
    }
}