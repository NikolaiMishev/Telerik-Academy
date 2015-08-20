using System;

class FirTree
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < n * 2 - 2; j++)
            {
                
                if ((i == 1 || i == n) && (j == n - 1))
                {
                    Console.Write("*");
                    
                }
                else if ((i > 1 && i <= n-2)&&(j > n - (i+1) && j < n + (i - 1) ))
                {
                    Console.Write("*");
                }
                else if(i == n -1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
                
            }
            Console.WriteLine();
        }
    }
}