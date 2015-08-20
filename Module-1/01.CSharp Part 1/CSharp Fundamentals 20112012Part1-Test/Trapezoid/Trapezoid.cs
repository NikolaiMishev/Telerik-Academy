using System;

class Trapezoid
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int height = n + 1;
        string minus = ".";
        string star = "*";

        for (int i = 0; i < n * 2; i++)
        {
            if (i < n)
            {
                Console.Write(minus);
            }
            else
                Console.Write(star);
        }


        Console.WriteLine();

        for (int i = 0; i < height - 2; i++)
        {
            for (int j = 1; j < n - i; j++)
            {
                Console.Write(minus);

            }
            Console.Write(star);
            for (int j = 1; j < n + i; j++)
            {
                Console.Write(minus);

            }
            Console.Write(star);

            Console.WriteLine();
        }

        for (int i = 0; i < n * 2; i++)
        {
            Console.Write(star);
        }
        Console.WriteLine();
    }
}
