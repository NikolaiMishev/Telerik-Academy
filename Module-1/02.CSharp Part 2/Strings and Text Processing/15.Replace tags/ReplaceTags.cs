//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>
//with corresponding tags [URL=…]…/URL].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceTags
{
    static void Main()
    {
        Console.Write("Enter HTML text: ");
        string text = Console.ReadLine();

        Console.WriteLine(Regex.Replace(text, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));
    }
}