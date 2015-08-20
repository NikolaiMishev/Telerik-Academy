//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;
class MaximalincreasingSequence
{
    static void Main()
    {


        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} number(s) : ", n);
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int lastSequenceIndex = 0;
        int longestSequenceLenght = 1;
        int tempLenght = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] - 1 == numbers[i - 1])
            {
                ++tempLenght;
                if (tempLenght > longestSequenceLenght)
                {
                    longestSequenceLenght = tempLenght;
                    lastSequenceIndex = i;
                }
            }
            else
            {
                tempLenght = 1;
            }
        }

        int skip = lastSequenceIndex - longestSequenceLenght + 1;
        var sequence = numbers.Skip(skip).Take(longestSequenceLenght).ToArray();
        Console.WriteLine(string.Join(", ", sequence));
    }
}
