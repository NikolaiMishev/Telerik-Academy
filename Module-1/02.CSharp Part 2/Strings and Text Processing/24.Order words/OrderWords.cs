//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OrderWords
{
    static void Main()
    {

        Console.Write("Enter text: ");
        string[] words = Console.ReadLine().Split(new[]{' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
