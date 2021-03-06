﻿﻿// Problem 16.* Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
// You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        short counter = 2;

        while(counter <= 1001)
        {
            if (counter % 2 == 0)
            {
                Console.Write(counter + ", ");
            }
            else
                Console.Write(-counter + ", ");
            counter++;
        }
        Console.WriteLine();
    }
}