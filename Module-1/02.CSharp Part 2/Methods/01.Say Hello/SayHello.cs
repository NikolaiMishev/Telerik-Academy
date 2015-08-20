//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
using System.Linq;

class SayHello
{
    static void Main()
    {       
        CheckInput(AskForName());
    }
    static string AskForName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static void CheckInput(string str)
    {
        bool chk = str.All(Char.IsLetter);
        if (chk)
        {
            Console.WriteLine();
            Console.WriteLine("Hello, {0}!", str );
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input!!!");
            Console.WriteLine();
        }
    }
}
