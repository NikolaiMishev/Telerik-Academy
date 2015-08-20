using System;

class OnesAndZeros
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2).PadLeft(32, '0');

        string[] one = { ".#.", 
                         "##.", 
                         ".#.", 
                         ".#.", 
                         "###"};

        string[] zero = { "###", 
                          "#.#", 
                          "#.#", 
                          "#.#", 
                          "###"};
      

        for (int row = 0; row < 5; row++)
        {
            for (int col = 16; col < 32; col++)
            {
                if (binary[col].Equals('0'))
                {
                    Console.Write(zero[row]);
                }
                else if (binary[col].Equals('1'))
                {
                    Console.Write(one[row]);
                }
                if (col != 31)
                {
                  Console.Write(".");
                }
                
            }
            Console.WriteLine();
        }

 
    }
}