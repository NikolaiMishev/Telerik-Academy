﻿//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        int bit = 3;
       
        int mask = 1 << bit;
        int result;

        result = number & mask;
        Console.WriteLine("The value of the 3rd bit is:" + (result>>bit));



    }
}