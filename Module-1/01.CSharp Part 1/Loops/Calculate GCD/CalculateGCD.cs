using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Entar intiger A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Entar intiger B: ");
        int b = int.Parse(Console.ReadLine());
        

        if (a < b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }
        int r = a % b;
        while (r != 0)
        {
            
                int temp = 0;
                temp = b;
                b = a;
                a = temp;
                
                temp = r;
                r = b;
                b = temp;

                r = a % b;
        }
            Console.WriteLine("The GCD  is : " + b);
     }
}
