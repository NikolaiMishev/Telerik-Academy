using System;

public class Cube
{
    public static void Main()
    {
 ////TODO make it work :}

        int number = int.Parse(Console.ReadLine());
        int left = 2;
        int right = (number * 2) - 1;
        for (int i = 0; i < (number * 2) - 1; i++)
        {
            for (int j = 0; j < (number * 2) - 1; j++)
            {
                if (i == number)
                {
                    right = 2;
                }

                if ((i > number && i < ((number * 2) - 1)) && (j > 1 && j <= number))
                {
                    Console.Write(" ");
                }
                else if ((i < number && j > number - left) || (i >= number && j < (number * 2) - right))
                {
                    Console.Write(":");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            right++;
            left++;
            Console.WriteLine();
        }
    }
}
