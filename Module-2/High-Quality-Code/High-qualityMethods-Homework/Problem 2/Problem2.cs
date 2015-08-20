using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Problem2
{
    public static void Main()
    {
        string input = Console.ReadLine();

        long[] sequence = ParseInput(input);

        long evenSum = 0;
        long checkJump = 0;
        for (int i = 1; i < sequence.Length;)
        {
            checkJump = CompareAndReturnNumber(sequence[i] , sequence[i - 1]);
            
            if (checkJump % 2 == 0)
            {
                i += 2;
                evenSum += checkJump;
            }
            else
            {
                i += 1;
            }

        }
        Console.WriteLine(evenSum);
    }

    private static long CompareAndReturnNumber(long number1, long number2)
    {
        ValidateLongNumber(number1);
        ValidateLongNumber(number2);

        if (number1 >= number2)
        {
           return number1 - number2;
        }
        else
        {
            return number2 - number1;
        }
    }
    private static long[] ParseInput(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Cannot parse input because it is null or empty!");
        }

        return input.Split(' ').Select(long.Parse).ToArray();
    }
    private static void ValidateLongNumber(long numb)
    {
        if (numb == 0)
        {
            throw new ArgumentNullException("Number cannot be 0 or lower!");
        }
    }
}
