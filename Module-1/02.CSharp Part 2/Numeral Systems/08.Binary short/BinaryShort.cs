// Problem 8. Binary short
// Write a program that shows the binary representation 
// of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter number between [-32768 and +32767]:");
        int number = int.Parse(Console.ReadLine());
        if (number < short.MinValue || number > short.MaxValue)
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        string binary = "";
        if (number < 0)
        {
            number = -number - 1;

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    binary += "1";
                }
                else
                {
                    binary += "0";
                }

                number = number / 2;
            }
            char[] array = binary.ToCharArray();
            Array.Reverse(array);
            string result = new string(array);
            Console.WriteLine(result.PadLeft(16, '1'));

        }
        else if (number > 0)
        {
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    binary += "0";
                }
                else
                {
                    binary += "1";
                }

                number = number / 2;
            }
            char[] array = binary.ToCharArray();
            Array.Reverse(array);
            string result = new string(array);
            Console.WriteLine(result.PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("Binary representation : " + new string('0', 16));
            return;
        }
    }
}