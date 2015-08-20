//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string input = Console.ReadLine();
        
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        if (dictionary.ContainsKey(input))
        {
            string value = dictionary[input];
            Console.WriteLine("{0} is a {1}!", input, value);
        }
    }
}
