//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the 
//entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
//Note: You may need to use for-loops (learn in Internet how).

using System;

class Program
{
    static void Main()
    {
        char c;
        for(int i=0; i< 255;i++)
        {
            c = (char)i;
            if (char.IsSymbol(c) || char.IsLetter(c) || char.IsNumber(c))
            Console.WriteLine((char)i);

        }
    }
}