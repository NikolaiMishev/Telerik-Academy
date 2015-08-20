//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main()
    {
   
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        
        List<string> forbidenWords = new List<string>{"PHP","CLR", "Microsoft"};
        StringBuilder newText = new StringBuilder(text);
        string[] words = text.Split(' ', '.');
        for (int i = 0; i < words.Length; i++)
        {
            if (forbidenWords.Contains(words[i]))
            {string replace = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                    replace += "*";
                }
                newText.Replace(words[i], replace);
            }
        }
        Console.WriteLine(newText.ToString());
        
    }
}
