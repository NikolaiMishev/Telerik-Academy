//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberasWords
{
    static void Main()
    {
        string[] smallnumbers = { "zero", "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine", "ten",
                                  "eleven", "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twnety"};
        string[] bignumbers = { "nada", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        Console.Write("Please enter a number between 0 and 999: ");
        int number = int.Parse(Console.ReadLine());

        int n  = 0;
        int a = 0, b = 0, c = 0;
        a = number / 100;
        b = (number / 10) % 10;
        c = (number % 100) % 10;
        
        if (number < 100 ||((b==0)&&(c==0)))
        {
            if (number <= 20)
            {
                Console.WriteLine(smallnumbers[number]);
            }
            else if (c != 0)
            {

                Console.WriteLine(bignumbers[b] + " " + smallnumbers[c]);
            }
            else if(b==0 && c==0)
            {
                Console.WriteLine(smallnumbers[a] + " hundred");
            }
            else
            {
                Console.WriteLine(bignumbers[b]);
            }
                
        }
        else //number>100
        {
            if (number > 100 && number < 110)
            {
                Console.WriteLine(smallnumbers[a] + " hundred and " + smallnumbers[c]);
            }
            else if (number > 109 && number < +120)
            {
                n = ((b+c-1)+10);
                Console.WriteLine(smallnumbers[a] + " hundred and " + smallnumbers[n]);
            }
            else if (c == 0)
            {
                Console.WriteLine(smallnumbers[a] + " hundred and " + bignumbers[b]);
            }
            else
            {
                Console.WriteLine(smallnumbers[a] + " hundred " + bignumbers[b] + " " + smallnumbers[c]);
            }
        }
        
      
       
        

    }
}