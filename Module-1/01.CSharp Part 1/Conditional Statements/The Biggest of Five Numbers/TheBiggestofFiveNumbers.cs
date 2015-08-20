//Write a program that finds the biggest of five numbers by using only five if statements.

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
        Console.Write("Enter D:");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter e:");
        double e = double.Parse(Console.ReadLine());

        double temp = 0;
        for (int i = 0; i < 5; i++)
        {
            if (a < b)
            {
                temp = 0;
                temp = a;
                a = b;
                b = temp;

            }
            if (b < c)
            {
                temp = 0;
                temp = b;
                b = c;
                c = temp;

            } 
            if (c < d)
            {
                temp = 0;
                temp = c;
                c = d;
                d = temp;

            } if (d < e)
            {
                temp = 0;
                temp = d;
                d = e;
                e = temp;

            }
        }
        Console.WriteLine("The biggest number is: " + a);

    }
}
