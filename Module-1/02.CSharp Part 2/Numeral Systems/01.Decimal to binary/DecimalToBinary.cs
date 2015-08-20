//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DecimalToBinary
{
    
    static void Main()
    {
        Console.Write("Enter a number :");
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine("Number binary representation: {0}",DecimalToBin(number));
    }

    static string DecimalToBin(long number)
    {
        string binary = "";
        while (number > 0)
        {
            if (number % 2 == 0)
            {
                binary += "0";
            }
            else
            {
                binary += "1";
            }

            number = number / 2;
        }

        char[] array = binary.ToCharArray();
        Array.Reverse(array);
        string result = new string (array);
       
        return result;
    }
}