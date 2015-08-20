//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first array:");
        int firstArrayLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstArrayLength];
        Console.WriteLine("Enter array:");
        for (int i = 0; i < firstArrayLength; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the length of the second array:");
        int secondArrayLength = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondArrayLength];
        Console.WriteLine("Enter array:");
        for (int i = 0; i < secondArrayLength; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
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
