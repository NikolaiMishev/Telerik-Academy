//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

using System.Collections.Generic;
class AppearanceCount
{
    static void Main()
    {

        Console.Write("Enter the array lenght: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = FillArray(n);

        Console.Write("Which number appearance  in the array you want to see: ");
        int numberToSeek = int.Parse(Console.ReadLine());
        int result = CountApearanceOFNumber(numberToSeek, array);
        Console.Clear();
        Console.SetCursorPosition(0, 10);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The number {0} appears {1} times int the array!", numberToSeek, result);
        Console.ResetColor();
    }

    static int[] FillArray(int n)
    {
        int[] array = new int[n];
        Console.WriteLine("Fill an array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static int CountApearanceOFNumber(int number, int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                count++;
            }
        }
        return count;
    }
}
