//Write a method that checks if the element at given position in given array of integers 
//is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter the array lenght: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = FillArray(n);

        CheckIfLarger(array);

    }
    static int[] FillArray(int n)
    {
        int[] array = new int[n];
        Console.WriteLine("Fill the array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void CheckIfLarger(int[] array)
    {
        Console.Write("Enter the position of element you want to check: ");
        int theNumber = int.Parse(Console.ReadLine());

        if (theNumber != 0 && theNumber < array.Length - 1)
        {
            if (array[theNumber] > array[theNumber - 1] && array[theNumber] > array[theNumber + 1])
            {
                Console.WriteLine("The number in the given position is larger than ist mates!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The number in the given position is NOT larger than ist mates!");
                Console.ResetColor();
            }
        }
        else
        {

            Console.WriteLine("The number has only 1 mate so i can't find out!");

        }


    }
}