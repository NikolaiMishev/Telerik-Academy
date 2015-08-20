//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming 
//logic.
//Print the variable values before and after the exchange.

using System;

class Program
{
    static void Main()
    {
        int a = 5, b = 10;
        int temp = 0;

        Console.WriteLine("A=" + a + "\nB=" + b);

        temp = a;
        a = b;
        b = temp;
        
        Console.WriteLine("After the exchange:\n" + "A=" + a + "\nB=" + b);



    }
}
