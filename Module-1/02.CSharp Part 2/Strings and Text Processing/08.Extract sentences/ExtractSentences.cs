//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text{atleast 2 sentences}: ");
        string text = Console.ReadLine();
        Console.Write("Enter word to check with: ");
        string word = Console.ReadLine();
        StringBuilder newText = new StringBuilder();

        string[] sentences = text.Split('.');
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(' ');
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == word)
                {
                    newText.Append(sentences[i]);
                    newText.Append(".");
                }
            }
        }
        Console.WriteLine(newText.ToString());
    }
}