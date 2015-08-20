//Write a method that reverses the digits of given decimal number.

using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        double newNumber = ReversedNumber(number);
       
        Console.WriteLine("The new number is:{0}", newNumber);

    }

    static double ReversedNumber(string number)
    {
        char[] arr = number.ToCharArray();
        Array.Reverse(arr);
        string reversed =  new string (arr);

        double reversedNumber = double.Parse(reversed);
        return reversedNumber;
    }
}