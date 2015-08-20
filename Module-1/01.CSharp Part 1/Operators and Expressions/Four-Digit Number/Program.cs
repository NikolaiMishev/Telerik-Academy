//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class Program
{
    static void Main()
    {
        int number = 0;
        do
        {
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());

        } while ((number / 1000 == 0) || (number+1 > 9999));

        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = (number / 1) % 10;
        
        Console.Write("The sum of the digits {0}+{1}+{2}+{3}=",a,b,c,d);
        Console.WriteLine(a+b+c+d);
        Console.WriteLine("The number in reversed order:{0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("The last digit in the first position:{0}{1}{2}{3}",d,a,b,c);
        Console.WriteLine("The second and the third digits exchanged:{0}{1}{2}{3}",a,c,b,d);


    }
}
