//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SeriesOfLetters
{
    static void Main()
    {

        Console.WriteLine("Enter text:");
        string sequence = Console.ReadLine();

        StringBuilder newStr = new StringBuilder();
        for (int i = 0; i < sequence.Length-1; i++)
        {
            if (sequence[i] == sequence[i+1])
            {
                continue;
            }
            else
            {
                newStr.Append(sequence[i], 1);
            }
        }
        newStr.Append(sequence[sequence.Length - 1], 1);
        Console.WriteLine(newStr.ToString());
    }
}