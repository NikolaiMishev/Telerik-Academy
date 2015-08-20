// Problem 7. One system to any other
// Write a program to convert from any numeral system of given base s 
// to any other numeral system of base d (2 ? s, d ? 16).

using System;
using System.Text;

class OneSystemToAnyOther
{
    static void Main()
    {
        


            Console.Write("Enter base numeral system:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number to convert in the numberal system above: ");
            string b = Console.ReadLine();
            Console.Write("Enter a numeral system to convert to:");
            int c = int.Parse(Console.ReadLine());
            if ((a < 2 || a > 16) || (c < 2 || c > 16))
            {
               
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid input!!!");
                Console.ResetColor();
                return;
            }
            
                ConvertToOther(ConvertNumberToDecimal(a, b), c);
            
           
        
    }

    static long ConvertNumberToDecimal(int numSystem, string number)
    {
        long newNumber = 0;
        int power = 1;
        int sign=0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] >= 'A' && number[i] <= 'F')
            {
                sign = (number[i] - 'A') + 10;
            }
            else if (number[i] >= '0' && number[i] <= '9')
            {
                sign = number[i] - '0';
             
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            newNumber += sign * power;
            power *= numSystem;
        }
     
        return newNumber;
    }

    static void ConvertToOther(long number, int system)
    {
        long remainder = 0;
        long temp = number;
        StringBuilder binary = new StringBuilder();

        while (temp > 0)
        {
            int index = 0;
            remainder = temp % system;
            if (remainder >= 10 && remainder <= 15)
            {
                binary.Insert(index, (char)(55 + remainder));
            }
            else
            {
                binary.Insert(index, remainder);
            }
            temp /= system;
            index++;
        }
        Console.WriteLine("The number in the selected numberable system is: " + binary);
    }
}