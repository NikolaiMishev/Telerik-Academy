using System;

//ones and zeros

class Program
{
    static void Main()
    {
        //input
            
        int num = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(num, 2).PadLeft(16, '0');
             

        string[] one = { ".#.", "##.", ".#.", ".#.", "###" };
        string[] zero = { "###", "#.#", "#.#", "#.#", "###" };

        for (int i = 0; i < 5; i++)
        {
            for (int j = 15; j >= 0; j--)
            {
                if (binary[j].Equals('1'))
                {
                    Console.WriteLine(binary[j]);
                }
            }

        }
            
    }       
}
