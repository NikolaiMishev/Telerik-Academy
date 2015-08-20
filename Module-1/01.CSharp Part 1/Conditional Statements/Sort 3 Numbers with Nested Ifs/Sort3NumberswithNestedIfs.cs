//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

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


        for (int i = 0; i < 3; i++)
        {
            if (a < b)
            {
                double temp = 0;
                temp = a;
                a = b;
                b = temp;

            }
            if (b < c)
            {
                double temp = 0;
                temp = b;
                b = c;
                c = temp;

            }
        }
        Console.WriteLine(a+" "+b+" "+c);

        



    }
}