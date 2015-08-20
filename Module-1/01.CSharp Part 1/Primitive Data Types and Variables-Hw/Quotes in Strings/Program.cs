//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class Program
{
    static void Main()
    {
        String without = "The use of quotations causes difficulties.";
        
        String with = "The \"use\" of quotations causes difficulties.";
        
        Console.WriteLine(without);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(with);
        Console.ForegroundColor = ConsoleColor.White;

    }
}