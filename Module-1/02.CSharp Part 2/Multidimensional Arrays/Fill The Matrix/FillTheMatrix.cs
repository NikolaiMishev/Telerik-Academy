using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        PrintMatrixA(n);
        PrintMatrixB(n);
        PrintMatrixC(n);

    }

    static void PrintMatrixA(int number)
    {


        int write = 1;
        Console.WriteLine("---------------a)---------------");
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                Console.Write("{0}  ", write);
                write += number;
            }
            write = i + 1;
            Console.WriteLine();

        }
        Console.WriteLine("--------------------------------");
    }

    static void PrintMatrixB(int number)
    {
        int[,] matrix = new int[number, number];

        int rowDown = 0;
        int rowUp = number - 1;
        int counter = 1;

        for (int coll = 0; coll < number; coll++)
        {
            if (coll == 0 || coll % 2 == 0)
            {
                while (rowDown < number)
                {
                    matrix[rowDown, coll] = counter;
                    rowDown++;
                    counter++;
                }

            }
            else
            {
                while (rowUp >= 0)
                {
                    matrix[rowUp, coll] = counter;
                    counter++;
                    rowUp--;
                }

            }
            rowDown = 0;
            rowUp = number - 1;
        }
        Console.WriteLine("---------------b)---------------");
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0}  ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------------------");

    }

    static void PrintMatrixC(int number)
    {

        int[,] matrix = new int[number, number];
        int counter = 1;
        int set = 1;
        int currentRow;
        for (int row = number - 1; row >= 0; row--)
        {
            currentRow = row;
            for (int coll = 0; coll < set; coll++)
            {

                matrix[currentRow, coll] = counter;
                counter++;
                currentRow++;
            }
            set++;
        }
        int h = 1;
        int currentColl = 0;
        for (int coll = 1; coll < number; coll++)
        {
            currentColl = coll;
            for (int row = 0; row < number - h; row++)
            {
                matrix[row, currentColl] = counter;
                currentColl++;
                counter++;
            }
            h++;
        }

        Console.WriteLine("---------------c)---------------");
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0}  ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------------------");
    }
}
