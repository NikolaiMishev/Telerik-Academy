//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
  //   ©

 //   © © 

//   ©   ©

//  © © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and 
//assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

using System;


class Program
{
    static void Main()
    {
        char ch = '©';
        int length = 3;


        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.Write(new string(' ',length));
        Console.WriteLine(ch);
        for (int i = 1; i <= 3; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("{0} {0} {0} {0}", ch);
            }
            else
                       Console.WriteLine(new string(' ',length-i) + ch + new string(' ',i+(i-1)) + ch);
        }
        Console.WriteLine();
      

    }
}

