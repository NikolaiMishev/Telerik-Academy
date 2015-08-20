//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class Program
{
    static void Main()
    {
        string[] signs = { "2", "3", "4", "5", "6", "7", "8"," 9", "10", "J", "Q", "K", "A" };
        
        Console.Write("Enter sign:");
        string entered = Console.ReadLine();
        bool check = false;
        for (int i = 0; i <= 12; i++)
        {
            if (entered == signs[i])
            {
                check = true;
                
            }
           
        }
        Console.WriteLine(check?"Yes":"No");

    }
}