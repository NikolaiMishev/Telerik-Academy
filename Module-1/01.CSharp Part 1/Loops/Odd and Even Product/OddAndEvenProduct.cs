//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Linq;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter numbers separated by space:");
        string str = Console.ReadLine();
        int[] num = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        int odd = 1;
        int even = 1;
        for (int i = 0; i < num.Length; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                odd *= num[i];
            }
            else
            {
                even *= num[i];
            }
            
        }
        Console.WriteLine(odd==even?"yes":"No");
    }
}