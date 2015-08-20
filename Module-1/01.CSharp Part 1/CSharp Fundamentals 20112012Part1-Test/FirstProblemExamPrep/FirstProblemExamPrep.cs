using System;

//Problem 1 : Peace of Cake

class FirstProblemExamPrep
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        decimal sum = (decimal)a / b + (decimal)c / d;


        if (sum >= 1)
        {
            Console.WriteLine((long)sum);
        }
        else
        {
            Console.WriteLine("{0:F22} ", sum);
        }
        Console.WriteLine("{0}/{1}", a * d + c * b, b * d);
        
    }
}
