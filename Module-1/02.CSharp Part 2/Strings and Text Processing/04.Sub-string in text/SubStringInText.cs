//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubStringInText
{
    static void Main()
    {

        Console.Write("Enter Text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a text to search : ");
        string litle = Console.ReadLine();
        int count = 0;
        int index = 0;
        while (index <= text.Length-litle.Length)
        {
            string substr = text.Substring(index, litle.Length);
            if (substr.ToUpper() == litle.ToUpper())
            {
                count++;
            }
            index++;
        }
        Console.WriteLine("The text contains ->{0}<- , {1} times!", litle, count);
    }
}