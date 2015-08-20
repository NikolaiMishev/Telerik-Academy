//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

using System;

class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.Write(a + ", ");
            int temp = a;
            a = b;
            b = temp + b;
            
        }
        
    }

}
