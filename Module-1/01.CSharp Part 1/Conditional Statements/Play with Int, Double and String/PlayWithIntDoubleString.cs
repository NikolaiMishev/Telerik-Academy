//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose your input:");
        Console.WriteLine("For int-->1:");
        Console.WriteLine("For double-->2:  ");
        Console.WriteLine("For string-->3:");
        int choice = int.Parse(Console.ReadLine());
        
        

        switch (choice)
        {
            case 1:
                Console.Write("Enter a number:");
                int intnum = int.Parse(Console.ReadLine());
                Console.WriteLine(intnum+1);
                break;
            case 2:
                Console.Write("Enter a number:");
                double doublenum = double.Parse(Console.ReadLine());
                Console.WriteLine(doublenum + 1);
                break;
            case 3:
                Console.WriteLine("Enter a string:");
                string str = Console.ReadLine();

                Console.WriteLine(str + "*");
                break;
        }


    }
}