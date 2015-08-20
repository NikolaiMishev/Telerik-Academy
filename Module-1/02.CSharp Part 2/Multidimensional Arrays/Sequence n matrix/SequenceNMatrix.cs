using System;

class SequenceNMatrix
{
    static void Main()
    {

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());

        FillStringMatrix(n, m);
    }
    static void FillStringMatrix(int row, int coll)
    {
        string[,] matrix = new string[row, coll];
        for (int i = 0; i < row; i++)
        {
            Console.WriteLine("Row {0}:", i);
            for (int j = 0; j < coll; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < coll; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }


        int currentSum = 1;
        int bestSum = 0;
        string bestStr = "";

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < coll; j++)
            {

                //horizontal
                for (int k = j; k < coll - 1; k++)
                {
                    if (matrix[i, k] == matrix[i, k + 1])
                    {
                        currentSum++;
                    }
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestStr = matrix[i, k];

                    }
                }
                
                currentSum = 1;
                //vertical
                for (int h = i; h < row-1; h++)
                {
                    if (matrix[h,j] == matrix[h+1,j])
                    {
                        currentSum++;
                    }
                    if (currentSum>bestSum)
                    {
                        bestSum = currentSum;
                        bestStr = matrix[h, j];
                    }
                }
                currentSum = 1;

                //diagonal

                for (int r = i, c = j; (r < row - 1) && (c < coll - 1);r++,c++)
                {
                    if (matrix[r,c] == matrix[r+1,c+1])
                    {
                        currentSum++;
                    }
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestStr = matrix[r, c];
                    }
                }

            }
        }
        for (int i = 0; i < bestSum; i++)
        {
             Console.Write("{0}, ",bestStr);
        }
        Console.WriteLine();

    }
}
