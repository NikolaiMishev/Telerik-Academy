//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_to_decimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hexadecimal number: ");
            string hexNumb = Console.ReadLine();
            Console.WriteLine("The number in decimal representation: {0}", HexToDec(hexNumb));
        }

        static long HexToDec(string hexaDecimal)
        {
            long result  = 0;
            long pow = 1;

            for (int i = hexaDecimal.Length - 1; i >= 0; i--)
            {
                int sign;
                switch (hexaDecimal[i])
                {
                    case 'A': sign = 10;
                        break;
                    case 'B': sign = 11;
                        break;
                    case 'C': sign = 12;
                        break;
                    case 'D': sign = 13;
                        break;
                    case 'E': sign = 14;
                        break;
                    case 'F': sign = 15;
                        break;
                    default: sign = hexaDecimal[i] - 48;
                        break;
                }
                result += sign * pow;

                pow *= 16;
            }
            return result;
        }
    }
}
