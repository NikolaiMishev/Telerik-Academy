//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();
        string newstr = word.Aggregate(string.Empty, (current, t) => current + string.Format(@"\n{0:X4}", (int)t));
        Console.WriteLine("\nResult -> {0}\n", newstr);
    }

   
}
