//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, 
//long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class Program
{
    static void Main()
    {
        byte one = 97;
        sbyte two = -115;
        short tree = -10000;
        ushort four = 52130;
        int five = 4825932;
        uint six = 4294967295;
        long seven = -1982045501230839128;
        ulong eight = 1982045501230839128;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("byte=" + one + "\n" + "sbyte=" + two + "\n" + "short=" + tree + "\n" +"ushort=" + four);
        Console.WriteLine("int=" + five + "\n" + "uint=" + six + "\n" + "long=" + seven + "\n" + "ulong=" + eight);
    
    }
}
