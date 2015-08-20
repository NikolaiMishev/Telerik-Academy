//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class Program
{
    static void Main()
    {
        int number = 0;
        do
        {

            Console.Write("Enter number(0<=number<=500):");
            number = int.Parse(Console.ReadLine());
        } while (!(number <= 500 && number >= 0));

          Console.Write("Enter floating-point number A:");
          double floatingNumberA = double.Parse(Console.ReadLine());
          Console.Write("Enter floating-point number B:");
          double floatingNumberB = double.Parse(Console.ReadLine());

          Console.Write("{0:X}", number);
          Console.Write(" " + "[" + Convert.ToString(number, 2).PadLeft(10, '0') + "]" + " ");
          Console.WriteLine("{0:F2}  {1:F3}",floatingNumberA,floatingNumberB);
    }

    
}