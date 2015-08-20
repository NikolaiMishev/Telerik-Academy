//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first array:");
        int firstArrayLength = int.Parse(Console.ReadLine());
        char[] firstArray = new char[firstArrayLength];
        Console.WriteLine("Enter array:");
        for (int i = 0; i < firstArrayLength; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the length of the second array:");
        int secondArrayLength = int.Parse(Console.ReadLine());
        char[] secondArray = new char[secondArrayLength];
        Console.WriteLine("Enter array:");
        for (int i = 0; i < secondArrayLength; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }
        int count = 0;
        if (firstArrayLength != secondArrayLength)
        {
            Console.WriteLine("The arrays are not equal, becouse they have deferent lengths!");
        }
        else
        {
            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;

                }
            }

            if (count == firstArrayLength)
            {
                Console.WriteLine("The arrays are fully equal!!!!");
            }
            else
            {
                Console.WriteLine("The arrays are with the same length but the characters are diferent!!!");
            }
        }
    }
}

