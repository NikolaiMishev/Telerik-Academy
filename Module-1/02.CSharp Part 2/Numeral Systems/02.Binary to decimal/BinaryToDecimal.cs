//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a number in binary: ");
        string number = Console.ReadLine();
        Console.WriteLine("The number in Decimal representation: " + BinaryToDec(number));

    }

    static double BinaryToDec(string binNumber)
    {
        double sum = 0;
        int length = binNumber.ToString().Length;
        int numnum = int.Parse(binNumber);
        for (int i = 0; i < length; i++)
        {
            int lastDigit = numnum % 10;
            sum = sum + lastDigit * (Math.Pow(2, i));
            numnum = numnum / 10;
        }
        return sum;
    }
}
