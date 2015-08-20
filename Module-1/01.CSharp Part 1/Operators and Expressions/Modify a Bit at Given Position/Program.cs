//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
//from the binary representation of n while preserving all other bits in n.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the bit:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of the bit:");
        int value = int.Parse(Console.ReadLine());
       
        Console.WriteLine("The number:          " + Convert.ToString(number, 2).PadLeft(32,'0'));
        int result = 0;
        int mask;
        if (value == 1)
        {
            mask = 1 << p;
            result = number | mask;
        }
        else //(value == 0)
        {
            mask = ~(1 << p);
            
            result = number & mask;
        }
       Console.WriteLine("The converted number:" + Convert.ToString(result, 2).PadLeft(32, '0'));
       Console.WriteLine("The converted number in decimal:" + result);

    }
}