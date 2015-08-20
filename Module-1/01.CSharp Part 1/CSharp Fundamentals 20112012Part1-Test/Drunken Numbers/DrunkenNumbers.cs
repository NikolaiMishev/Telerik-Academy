using System;
using System.Linq;

class DrunkenNumbers
{
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());
        int countMitkosBiers = 0;
        int countVladkosBiers = 0;
        for (int i = 0; i < rounds; i++)
        {
            int number = int.Parse(Console.ReadLine());
            double digitCountDouble = Math.Floor(Math.Log10(number) + 1);
            int digitCount = Convert.ToInt32(digitCountDouble);

            int[] numberInArr = new int[digitCount];

            for (int k = 0; k < digitCount; k++)
            {
                numberInArr[k] = number % 10;
                number = number / 10;
            }

            for (int j = 0; j < digitCount; j++)
            {
                if (digitCount % 2 == 0)
                {
                    if (j < digitCount / 2)
                    { 
                        countVladkosBiers += numberInArr[j];
                    }
                    if (j >= digitCount / 2)
                    {
                       countMitkosBiers += numberInArr[j];
                    }

                }
                else 
                {
                    if (j <= (digitCount / 2))
                    {
                       countVladkosBiers += numberInArr[j];
                    }
                    if (j >= digitCount / 2)
                    { 
                        countMitkosBiers += numberInArr[j];
                    }
                }
            }
        }
        if (countMitkosBiers > countVladkosBiers)
        {
            Console.WriteLine("M {0}",countMitkosBiers-countVladkosBiers);
        }
        else if (countVladkosBiers > countMitkosBiers)
        {
            Console.WriteLine("V {0}",countVladkosBiers-countMitkosBiers);
        }
        else if (countMitkosBiers == countVladkosBiers)
        {
            Console.WriteLine("No {0}",countMitkosBiers+countVladkosBiers);
        }
    }
}