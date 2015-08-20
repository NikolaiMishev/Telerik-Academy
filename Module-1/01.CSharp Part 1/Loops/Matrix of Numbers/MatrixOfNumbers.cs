//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix.
//Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 20: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("matrix");
       
        for (int i = 1; i <= n; i++)
        {
            
                for (int j = 0; j < n; j++)
                {
                    
                    Console.Write(i+j);
                    

                }
            
            Console.WriteLine();
        }

    }
}