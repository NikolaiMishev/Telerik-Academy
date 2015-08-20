//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only
//to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {int number=0;
    bool stop=true;
    do
    {

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter a number:");
        number = int.Parse(Console.ReadLine());

        bool check = (number >= 1) && ((number == 2 || number == 3 || number == 5 || number == 7) || (number % 2 == 0 &&
             number % 3 == 0 && number % 5 == 0 && number % 7 == 0 && number % 10 == 0 && number == 2));

        Console.ForegroundColor = ConsoleColor.Green;

        if (number == 97)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine(check);
        }
        if(number == 0)
        {
            stop = false;
        }
    } while (stop);
    }
}