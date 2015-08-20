//Write a method that returns the index of the first element in array that is larger than its neighbours,
//or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {

        Console.Write("Enter the array lenght: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = FillArray(n);

        int num = CheckFirstLarger(array);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(num);
        Console.ResetColor();
    }

    static int[] FillArray(int n)
    {
        int[] array = new int[n];
        Console.WriteLine("Fill the array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        return array;
    }

    static int CheckFirstLarger(int[] array)
    {
        for (int i = 1; i < array.Length-1; i++)
        {

            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
            }
        }
        return -1;
    }
}
