using System;

class BatBoikoTower
{
    static void Main()
    {

        int h = int.Parse(Console.ReadLine());

        int left = h-1;
        int right = h;
        int line = 1;
        for (int row = 0; row < h; row++)
        {
            for (int col = 0; col < h*2; col++)
            {
                if (col == left)
                {
                    Console.Write("/");
                }
                else if (col == right)
                {
                    Console.Write("\\");
                }
                else if (row == line)
                {
                    
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            left--;
            right++;
        }
    }
}