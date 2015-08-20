using System;

class MitkosBits
{
    static void Main()
    {
        int[,] field = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(currentNumber, 2);
            binaryNumber = binaryNumber.PadLeft(8, '0');

            for (int k = 0; k < 8; k++)
            {
                switch (binaryNumber[k])
                {
                    case '0': field[i, k] = 0; break;
                    case '1': field[i, k] = 1; break;

                    default: break;
                }

            }
        }
          //for (int i = 0; i <= 8 - 1; i++)
          //{
          //    for (int j = 0; j <= 8 - 1; j++)
          //    {
          //        Console.Write(field[i, j]);
          //    }
          //    Console.WriteLine();
          //
          //}
        int counterBefore = 0;
        int counterAfter = 0;
       
        for (int pilar = 1; pilar < 7; pilar++)
        {
           
            counterAfter = 0;
            counterBefore = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j < pilar && field[i, j] == 1)
                    {
                        counterBefore++;
                    }
                    else if (j > pilar && field[i, j] == 1)
                    {
                        counterAfter++;
                        
                    }
                }

            }
            if (counterBefore == counterAfter && counterAfter > 0 && counterBefore > 0)
            {
                if (pilar == 1)
                {
                    pilar = 6;
                }
                else if (pilar == 2)
                {
                    pilar = 5;
                }
                else if (pilar == 3)
                {
                    pilar = 4;
                }
                else if (pilar == 4)
                {
                    pilar = 3;
                }
                else if (pilar == 5)
                {
                    pilar = 2;
                }
                else if (pilar == 6)
                {
                    pilar = 1;
                }
                Console.WriteLine(pilar);
                Console.WriteLine(counterBefore);
                break;
            }

        }

        if (counterAfter != counterBefore || (counterAfter == 0 && counterBefore == 0))
        {
            Console.WriteLine("No");
        }


    }
}