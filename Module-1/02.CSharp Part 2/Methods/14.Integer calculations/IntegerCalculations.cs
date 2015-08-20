//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        decimal[] array = { 10, 9, 4, 6, 2, -7, 1, 8, 9 };

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("The Sum is: {0}", Sum(array));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The Min is: {0}",Min(array));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The Max is: {0}", Max(array));
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("The Average is: {0:F2}", Average(array));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Product is: {0}", Product(array));
        Console.ResetColor();
    }
    static decimal Sum(decimal[] arr)
    {
        decimal sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static decimal Min(decimal[] array)
    {
        decimal min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static decimal Max(decimal[] array)
    {
        decimal max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static decimal Average(decimal[] array)
    {
        decimal avrg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            avrg += array[i];
        }
        decimal result = avrg / array.Length;
        return result;
    }

    static decimal Product(decimal[] array)
    {
        decimal product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
}

