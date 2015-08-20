//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary representation: ");
        string binNumber = Console.ReadLine().PadLeft(32, '0');
       
        PrintHex(BinaryToHexadec(binNumber));


    }
    static string BinaryToHexadec(string number)
    {
        string result = string.Empty;

        for (int i = 0; i < number.Length; i+=4)
        {
            string newNumber = number.Substring(i,4);
            
            switch (newNumber)
            {
                case "0000":
                    result += "0";
                    break;
                case "0001":
                    result += "1";
                    break;
                case "0010":
                    result += "2";
                    break;
                case "0011":
                    result += "3";
                    break;
                case "0100":
                    result += "4";
                    break;
                case "0101":
                    result += "5";
                    break;
                case "0110":
                    result += "6";
                    break;
                case "0111":
                    result += "7";
                    break;
                case "1000":
                    result += "8";
                    break;
                case "1001":
                    result += "9";
                    break;
                case "1010":

                    result += "A";
                    break;
                case "1011":

                    result += "B";
                    break;
                case "1100":

                    result += "C";
                    break;
                case "1101":
                    result += "D";
                    break;
                case "1110":
                    result += "E";
                    break;
                case "1111":
                    result += "F";
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine();
        return result;
    }
    static void PrintHex(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != '0')
            {
                Console.Write("The number in hexadecimal representation: ");
                for (int j = i; j < str.Length; j++)
                {
                    Console.Write(str[j]);
                }
                Console.WriteLine();
                break;
            }
            
        }
    }
    
}
