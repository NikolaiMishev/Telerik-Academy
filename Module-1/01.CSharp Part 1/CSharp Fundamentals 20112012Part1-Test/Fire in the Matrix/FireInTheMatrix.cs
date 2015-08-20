using System;

class FireInTheMatrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int left = number / 2;
        int right = (number / 2) + 1;

        for (int i = 1; i <= number / 2; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                if (j == left || j == right)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            left--;
            right++;
            Console.WriteLine();
        }
        
        int left2 = 1;
        int right2 = number;

        for (int i = 1; i <= number / 4; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                if (j == left2 || j == right2)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            left2++;
            right2--;
            Console.WriteLine();
        }
        for (int i = 0; i < number; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        int left3 = 1;
        int right3 = number;
       
        for (int i = 1; i <= (number / 2); i++)
        {
            for (int j = 1; j <= number; j++)
            {
                if (j >= left3&&j <= number/2)
                {
                    Console.Write("\\");
                    
                }
                else if(j <= right3&&j>number/2)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(".");
                }
                
            }
            Console.WriteLine();
            left3++;
            right3--;
        }

    }
}