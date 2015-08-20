//Write a method that returns the last digit of given integer as an English word.

using System;
using System.Linq;

class EnglishDigit
{
    static void Main()
    {

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string digit = PrintLastDigit(number);
        Console.WriteLine(digit);
    }
    static string PrintLastDigit(int number)
    {
        string digitAsWord = null;
        string[] digits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        int lastDigit = number%10;
        for (int i = 0; i < digits.Length; i++)
        {
            if (lastDigit == i)
            {
                digitAsWord = digits[i];
            }
        }
        return digitAsWord;
    }
}
