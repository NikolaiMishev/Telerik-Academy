//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter text[max 20 characters]: ");
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            if (text.Length > 20)
            {
                Console.WriteLine("Invalid input!!!");
            }
            if (text.Length == 20)
            {
                Console.WriteLine("The text have exactly 20 characters!!!");
               
            }
            else
            {
                newText.Append(text);

                newText.Append('*', 20 - text.Length);

                Console.WriteLine(newText.ToString());
                break;
            }
        }





    }
}