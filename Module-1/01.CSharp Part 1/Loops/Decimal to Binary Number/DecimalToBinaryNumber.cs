//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;


class DecimalToBinaryNumber
{
    static void Main()
    {

        Console.Write("Enter a number :");
        long number = long.Parse(Console.ReadLine());
        string binary = "";
       while(number>0)
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

       Console.WriteLine(array);

    }
} 


        

