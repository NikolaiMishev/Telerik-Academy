//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
         Console.Write("Enter a text: ");
         string str = Console.ReadLine();

         StringBuilder reversedText = new StringBuilder(str.Length);

         for (int i = str.Length-1; i >= 0; i--)
         {
             reversedText.Append(str[i]);
         }
         Console.WriteLine("Reversed: {0}", reversedText);
    }
}
