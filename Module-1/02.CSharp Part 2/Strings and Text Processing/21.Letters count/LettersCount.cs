//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string[] text = Console.ReadLine().Split(new[] { ' ', '.', ',', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

        string newtext = string.Join("", text).ToUpper();
        char[] letters = newtext.ToArray();
        Array.Sort(letters);
        string sortedLetters = string.Join("", letters);
        
        int counter = 1;
        int i = 0;
        Console.WriteLine("How many times each letter is found:");
        for (i = 0; i < sortedLetters.Length - 1; i++)
        {
           
            if (letters[i] == letters[i + 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0}-{1}", sortedLetters[i], counter);
                counter = 1;
            }
        }
        Console.WriteLine("{0}-{1}", sortedLetters[i], counter);
       
    }
}
