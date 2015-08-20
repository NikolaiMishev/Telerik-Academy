﻿//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter numbers separated by space: ");
        string input = Console.ReadLine();
        int[] numbers = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        long sum = 0;
        foreach (var numb in numbers)
        {
            sum += numb;
        }
        Console.WriteLine("The sum is: "+sum);

    }
}