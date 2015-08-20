using System;

class TrailingZeroesInN
{
    static void Main()
    {   
        Console.Write("Enter number to count: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int devider = 5;
        while (n / devider >= 0)
        {

            counter += n / devider;
            devider *= 5;
        }
        Console.WriteLine(counter);
    }
}




