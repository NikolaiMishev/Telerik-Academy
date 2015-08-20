//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;
using System.Collections.Generic;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("*[1]To reverses the digits of a number:              *");
            Console.WriteLine("*[2]To calculate the average of sequence of integers:*");
            Console.WriteLine("*[3]To solve a linear equation(a*x+b=0):             *");
            Console.WriteLine("*[0]To exit enter:                                   *");
            Console.WriteLine("******************************************************");
            Console.Write("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            bool exit = true;
            switch (choice)
            {
                case 1:
                    ReverseDigit();
                    break;
                case 2:
                    CalculateAverage();
                    break;
                case 3:
                    SolveEquation();
                    break;
                case 0:
                    exit = false;
                    break;

            }
            if (!exit)
            {
                break;
            }

        }

    }
    static void ReverseDigit()
    {

        Console.Write("\nPlease enter a positive number: ");
        string number = Console.ReadLine();

        char[] arr = number.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        decimal reversedNumb = decimal.Parse(reversed);
        if (reversedNumb >= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reversed number: {0}", reversedNumb);
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Invalid input!!!");
            ReverseDigit();
        }

    }

    static void CalculateAverage()
    {
        Console.Write("Enter the lenght of the sequence:");
        int n = int.Parse(Console.ReadLine());
        int[] sequence = new int[n];
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            Console.Write("{0}: ", i + 1);
            char currentInt= char.Parse(Console.ReadLine());
            if (Char.IsDigit(currentInt))
            {
                string str = currentInt.ToString();
                sequence[i] = int.Parse(str);
                sum += sequence[i];
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid input!!");
                Console.ResetColor();
                CalculateAverage();
            }

            
        }
        decimal result = (decimal)sum / n;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The average is: {0}", result);
        Console.ResetColor();
    }

    static void SolveEquation()
    {
        Console.Write("Enter A[not equal to 0]: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Invalid input!!!");
            Console.ResetColor();
            SolveEquation();
        }
        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        int c = int.Parse(Console.ReadLine());
        decimal result = (decimal)a*b+c;
        Console.WriteLine("{0}*{1}+{2}={3}",a,b,c,result);
      
    }
}
