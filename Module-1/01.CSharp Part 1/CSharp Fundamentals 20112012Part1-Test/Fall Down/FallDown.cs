using System;

class FallDown
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
       // for (int i = 0; i <= 8-1; i++)
     //   {
        //    for (int j = 0; j <= 8-1; j++)
         //   {
           //     Console.Write(field[i,j]);
          //  }
         //   Console.WriteLine();
                
     //   }
        for (int k = 0; k < 8; k++)
        {
            bool moved = true;
            while (moved)
            {
                moved = false;
                for (int i = 7; i > 0; i--)
                {
                    if ((field[i, k] == 0) && (field[i - 1, k] == 1))
                    {
                        field[i - 1, k] = 0;
                        field[i, k] = 1;
                        moved = true;
                    }
                }
            }
        }

        for (int i = 0; i < 8; i++)
        {
            string num = "";
            for (int k = 0; k < 8; k++)
            {
                num += field[i, k].ToString();
            }
            Console.WriteLine(Convert.ToInt32(num, 2));
        }
    }
}