using System;
using System.Numerics;

public class Example
{
    public static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger check = number;
        BigInteger final = number;
        int digitCount = 0;
        while (true)
        {

            number = number / 10;
            digitCount++;
            if (number == 0)
            {
                break;
            }
        }

        BigInteger[] numberInArray = new BigInteger[digitCount + 1];
        for (int i = 1; i <= digitCount; i++)
        {
            numberInArray[i] = check % 10;
            check /= 10;
           
        }

        BigInteger sumOfOdd = 0;
        BigInteger sumOfEven = 0;

        for (int i = 1; i <= digitCount; i++)
        {
            if (i % 2 != 0)
            {
                sumOfOdd += (numberInArray[i] * (i * i));

            }
            else if (i % 2 == 0)
            {
                sumOfEven += ((numberInArray[i] * numberInArray[i]) * i);
            }
        }
        BigInteger specialSum = sumOfEven + sumOfOdd;
        Console.WriteLine(specialSum);
        char alhabet = 'A';

        BigInteger alphabetSequenceLength = specialSum % 10;
        BigInteger sumator = specialSum;

        if (sumator > 26)
        {
            while (sumator >= 26)
            {
                sumator = sumator - 26;
            }
        }
        if (alphabetSequenceLength != 0)
        {
            for (int i = 0; i < alphabetSequenceLength; i++)
            {
                if (sumator + i == 26)
                {
                    sumator = -i;
                }
                Console.Write((char)(alhabet + (sumator + i)));

            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("{0} has no secret alpha-sequence", final);
        }
    }
}


