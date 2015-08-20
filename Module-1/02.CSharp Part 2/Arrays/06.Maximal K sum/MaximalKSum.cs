//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {                                                                   
        Console.WriteLine("Enter n--the length of an arraty: ");        
        int n = int.Parse(Console.ReadLine());                          
        Console.WriteLine("Enter K: ");                                 
        int k = int.Parse(Console.ReadLine());                          
                                                                        
        Console.WriteLine("Enter {0} number(s):", n);                   
        int[] array = new int[n];                                       
        for (int i = 0; i < array.Length; i++)                          
        {                                                               
            array[i] = int.Parse(Console.ReadLine());                   
        }

        Array.Sort(array);
        int sum = 0;
        for (int i = array.Length-1;  i >= 0 && k != 0; k--, i--)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }
}