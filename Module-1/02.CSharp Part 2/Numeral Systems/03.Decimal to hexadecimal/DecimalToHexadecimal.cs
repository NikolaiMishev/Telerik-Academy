//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("The number in Hexadecimal representation: {0}", DecimalToHex(number));
    }

    static StringBuilder DecimalToHex(long number)
    {
        StringBuilder binary = new StringBuilder();
        while (number > 0)
        {
            int index = 0;
            char hexValue = '0';
            long remainder = number % 16;
            if (remainder > 9)
            {
                switch (remainder)
                {
                    case 10: hexValue = 'A';
                        break;
                    case 11: hexValue = 'B';
                        break;
                    case 12: hexValue = 'C';
                        break;
                    case 13: hexValue = 'D';
                        break;
                    case 14: hexValue = 'E';
                        break;
                    case 15: hexValue = 'F';
                        break;
                    default: Console.WriteLine("Fail");
                        break;
                }
                binary.Insert(index, hexValue);
            }
            else
            {
                binary.Insert(index, remainder);
            }
            number /= 16;
            index++;
        }
      
        return binary;
    }
}