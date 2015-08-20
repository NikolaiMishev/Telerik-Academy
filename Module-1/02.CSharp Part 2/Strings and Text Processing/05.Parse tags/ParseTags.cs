//You are given a text. Write a program that changes the text in all regions surrounded by the tags 
//<upcase> and </upcase> to upper-case.
//The tags cannot be nested.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PriceTags
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        StringBuilder newText = new StringBuilder();
        
       
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                i += 8;
                while (text[i] != '<')
                {
                    newText.Append(text[i].ToString().ToUpper());
                    i++;
                }
                i += 8;
            }
            else
            {
                newText.Append(text[i]);
            }
        }
        Console.WriteLine(newText.ToString());
    }
}