//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the bit:");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;

        int check = number & mask;
        int result = check >> p;
        bool finale = result==1;
        Console.Write("Is the bit value \"1\":");
        if (finale)
        {
            Console.WriteLine("True");

        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
