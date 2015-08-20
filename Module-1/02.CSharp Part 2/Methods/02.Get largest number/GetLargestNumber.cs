//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {

        Console.Write("Enter A:");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Enter B:");
        int B = int.Parse(Console.ReadLine()); 
        Console.Write("Enter C:");
        int C = int.Parse(Console.ReadLine());

        int largestValue = GetMax(GetMax(A, B), C);
        Console.WriteLine("The largest value is {0}", largestValue);
    }
    
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
