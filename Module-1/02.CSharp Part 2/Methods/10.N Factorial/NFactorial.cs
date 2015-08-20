//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
using System;
using System.Linq;
using System.Numerics;
class NFactorial
{
    static void Main()
    {
        int[] arr = new int[100];
        for (int i = 1; i <= arr.Length; i++)
        {
            arr[i-1] = i;
        }

        CalculateFactorial(arr);
    }

    static void CalculateFactorial(int[] array)
    {
        for (int i = 1; i <= array.Length; i++)
        {
            
            BigInteger factorial = Factorial(i);
            Console.Write("{0}:",i);
            Console.WriteLine(factorial);
        }
    }

    static BigInteger Factorial(int i)
    {
        BigInteger fact = i;
        while (i > 1)
        {
            fact *= i - 1;
            i--;
        }
        return fact;
    }
}