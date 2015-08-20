namespace Problem1
{
    using System;
    using System.Text;

    public class Problem1
    {
        private static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            long finalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int power = input[i].Length - 1;
                for (int j = 0; j < input[i].Length; j++)
                {
                    long value = GetValue(input[i][j]);
                    finalSum += value * PowerOf23(power);
                    power--;
                }

            }
            Console.WriteLine(ConvertToOtherNumericSystem(finalSum, 23) + " = " + finalSum);
        }

        private static long PowerOf23(int power)
        {
            if (power == 0)
            {
                throw new ArgumentNullException("The given power is 0!");
            }
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 23;
            }
            return result;
        }

        private static int GetValue(char p)
        {

            switch (p)
            {
                case 'a': return 0;
                case 'b': return 1;
                case 'c': return 2;
                case 'd': return 3;
                case 'e': return 4;
                case 'f': return 5;
                case 'g': return 6;
                case 'h': return 7;
                case 'i': return 8;
                case 'j': return 9;
                case 'k': return 10;
                case 'l': return 11;
                case 'm': return 12;
                case 'n': return 13;
                case 'o': return 14;
                case 'p': return 15;
                case 'q': return 16;
                case 'r': return 17;
                case 's': return 18;
                case 't': return 19;
                case 'u': return 20;
                case 'v': return 21;
                case 'w': return 22;
                default: throw new ArgumentException();
            }
        }

        static string ConvertToOtherNumericSystem(long number, int system)
        {

            if (number < 1)
            {
                throw new ArgumentException("The given number must be greater than 0!");
            }
            if (system < 0)
            {
                throw new ArgumentException("The given system is smaller than 0!");
            }

            long remainder = 0;
            long tempNumber = number;
            StringBuilder binary = new StringBuilder();

            while (tempNumber > 0)
            {
                int index = 0;
                remainder = tempNumber % system;
                if (remainder >= 10 && remainder <= 22)
                {
                    binary.Insert(index, (char)(remainder + 'a'));
                }
                else
                {
                    binary.Insert(index, (char)(remainder + 'a'));
                }
                tempNumber /= system;
                index++;
            }
            return binary.ToString();
        }
    }
}