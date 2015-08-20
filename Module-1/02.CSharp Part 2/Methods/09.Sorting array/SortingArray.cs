//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class GetPortionFromArray
{
    static void Main()
    {
        int[] numbers = { -22, 44, -9, 444, 60, 2, -4, 100, 57, 95, 31, 61, 17, 81, 22, 6, -88, 22, 33, 
                          -233, 900, -1000, -66, 123, 2, 333, 0, 55, 224, 28, -99, 5, 51, 164, 3, 672};
        Console.WriteLine("Descending Order:");
        PrintArray(SortDescending(numbers));
        Console.WriteLine("Ascending Order:");
        PrintArray(SortAscending(numbers));
    }

    static int FindMaxIndex(int[] array, int start)
    {
        int maxValue = int.MinValue;
        int maxIndex = start;
        for (int i = start; i < array.Length; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }

    static int[] SortDescending(int[] array)
    {
        
        int currentMax = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            currentMax = FindMaxIndex(array, i);
            int temp = array[i];
            array[i] = array[currentMax];
            array[currentMax] = temp;
        }
        return array;
    }

    static int[] SortAscending(int[] array)
    {
        SortDescending(array);
        Array.Reverse(array);

        return array;
    }
}