using System;

class Eggcelent
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        int left = number + 1;
        int right = (number * 2) + 1;
        int leftBot = 2;
        int rightBot = (number*3);
        for (int i = 1; i <= number*2 ; i++)
        {
            for (int j = 1; j <= (number*3)+1; j++)
            {
                if ((i == 1 || i == number*2) && (j > number+1  && j < (number * 2)+1))
                {
                    Console.Write("*");
                }
                else if ((i > number/2 && i <= (number + (number/2))) && (j == 2 || j == (number*3)))
                {
                    Console.Write("*");
                }
                else if (j == left+1 || j == right-1)
                {
                    Console.Write("*");
                }
                else if (i >= (number + (number / 2)) && (j == leftBot || j == rightBot))
                {
                    Console.Write("*");
                }
                else if ((i == number || i == number + 1) && (j > 1 && j < number*3))
                {
                    if (i == number && j % 2 != 0)
                    {
                        Console.Write("@");
                    }
                    else if (i == number + 1 && j % 2 == 0)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    Console.Write(".");
                } 
            }
            left-=2;
            right+=2;
            if(i >= (number + (number / 2)))
            {
                leftBot += 2;
                rightBot -= 2;
            }
           ;
            Console.WriteLine();
        }

    }
}
