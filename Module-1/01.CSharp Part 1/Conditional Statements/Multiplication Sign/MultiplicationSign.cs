//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter A:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter C:");
        double c = double.Parse(Console.ReadLine());

        int count = 0;
        if (a < 0)
        {
            count++;
        }

        if (b < 0)
        {
            count++;
        }

        if (c < 0)
        {
            count++;
        }
        if (!(a == 0 || b == 0 || c == 0))
        {

            if (count % 2 != 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
            
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
