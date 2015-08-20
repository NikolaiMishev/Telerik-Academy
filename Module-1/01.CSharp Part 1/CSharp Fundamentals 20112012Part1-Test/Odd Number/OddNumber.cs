using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] sequence = new long[n];
        for (int i = 0; i < n; i++)
        {
            sequence[i] = long.Parse(Console.ReadLine());
        }
        

        for (int i = 0; i < n; i++)
        {
            int counter = 0;
            for (int j = 0; j < n; j++)
            {
            
                if (sequence[i] == sequence[j])
                {
                    counter++;
                    
                }
            }
            if (!(counter % 2 == 0)||(counter == 1))
            {
                Console.WriteLine(sequence[i]);
                break;
            }
        }
    }
}