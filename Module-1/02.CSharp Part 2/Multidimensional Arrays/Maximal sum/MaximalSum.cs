using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());

        Matrix(n, m);
    }

    static void Matrix(int row, int coll)
    {
        Console.WriteLine("Fill matrix:");
        int[,] matrix = new int[row, coll];
        for (int i = 0; i < row; i++)
        {
            Console.WriteLine("Row {0}:",i);
            for (int j = 0; j < coll; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int currSum = 0;
        int maxSum = 0;
        int maxX = 0;
        int maxY = 0;

     
        int p = 3;
        int q = 3;

  
        for (int i = 0; i < row - p + 1; i++)
        {
            for (int j = 0; j < coll - q + 1; j++)
            {
                currSum = 0;

           
                for (int k = 0; k < p; k++)
                {
                    for (int l = 0; l < q; l++)
                    {
                        currSum += matrix[i + k, j + l];
                    }
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    maxX = i;
                    maxY = j;
                }
            }

           }
        for (int f = 0; f < row; f++)
        {
            Console.WriteLine();
            for (int j = 0; j < coll; j++)
            {
                Console.Write(matrix[f, j] + " ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Maximal sum is in window[{0},{1}-{2},{3}] in the array is: {4}", maxX, maxY, maxX + p - 1, maxY + q - 1, maxSum);
        
}
}
