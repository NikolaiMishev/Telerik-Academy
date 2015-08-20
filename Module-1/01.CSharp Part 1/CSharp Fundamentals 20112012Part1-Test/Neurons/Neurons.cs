using System;

class Neurons
{
    static void Main()
    {
        int[,] field = new int[32,32];
        int counter = 0;

        for (int i = 0; i < 32; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(currentNumber, 2);
            binaryNumber = binaryNumber.PadLeft(32, '0');

            for (int k = 0; k < 32; k++)
            {
                switch (binaryNumber[k])
                {
                    case '0': field[i, k] = 0; break;
                    case '1': field[i, k] = 1; break;

                    default: break;
                }

            }
            counter++;
            if (currentNumber == -1)
            {
                counter -= 1;
                break;
            }
        }

        for (int i = 0; i < counter; i++)
        {
            for (int j = 0; j < 32; j++)
            {

                Console.Write(field[i,j]);

            }
            Console.WriteLine();
        }



    }
}
