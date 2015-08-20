using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger numberOne = int.Parse(Console.ReadLine());
        BigInteger numberTwo = int.Parse(Console.ReadLine());
        BigInteger numberTree = int.Parse(Console.ReadLine());
        BigInteger n = int.Parse(Console.ReadLine());
        
        BigInteger result = 0;

        if (n == 1)
        {
            Console.WriteLine(numberOne);
        }
        else if (n == numberTwo)
        {
            Console.WriteLine(numberTwo);
        }
        else if (n == 3)
        {
            Console.WriteLine(numberTree);
        }
        else if (n > 3)
        {

            for (int i = 3; i < n; i++)
            {
                result = numberOne + numberTwo + numberTree;
                numberOne = numberTwo;
                numberTwo = numberTree;
                numberTree = result;
            }
            Console.WriteLine(result);
        }
        

    }
}
