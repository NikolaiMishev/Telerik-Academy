//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} number(s) : ", n);
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int count = 0;
        int countLongestSequence = 1;
        int holder = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
                if (count > countLongestSequence)
                {
                    countLongestSequence = count;
                    holder = array[i];
                   
                   
                }
            }
            else
            {
                count = 1;
            }
           
        }
       
        for (int i = 0; i < countLongestSequence; i++)
        {
            Console.Write("{0}, ", holder);
        }
        Console.WriteLine();
    }
}