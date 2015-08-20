using System;

class MollyAndMolly
{
    static void Main()
    {
       long a = int.Parse(Console.ReadLine());
       long b = int.Parse(Console.ReadLine());
       long c = int.Parse(Console.ReadLine());

        long result = 0;
        if (b == 2)
        {
            result = a % c;
        }
        else if (b == 4)
        {
            result = a + c;
            
        }
        else if (b == 8)
        {
            result = a * c;
        }

        long secondResult = 0;

        if (result % 4 == 0)
        {
            secondResult = result / 4;
            Console.WriteLine(secondResult);
            Console.WriteLine(result);
        }
        else if (result % 4 != 0)
        {
            secondResult = result % 4;
            Console.WriteLine(secondResult);
            Console.WriteLine(result);
        }
    }
}