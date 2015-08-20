//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter an epression: ");
        string input = Console.ReadLine();
        int counterOpenBr = 0;
        int counterCloseBr = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                counterOpenBr++;
            }
            if (input[i] == ')')
            {
                counterCloseBr++; 
            }
            if ( counterCloseBr > counterOpenBr)
            {
                Console.WriteLine("Incorrect!!!");
                return;
            }
           
        }
        if (counterCloseBr == counterOpenBr)
        {
            Console.WriteLine("Correct!!!");
           
        }
        else
        {
            Console.WriteLine("Incorrect!!!");
        }
        
    }
}
