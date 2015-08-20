//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive
//names. Print the data at the console.

using System;

class Program
{
    static void Main()
    {
        String firstName = "Nikolai";
        String lastName = "Mishev";
        byte age = 22;
        String gander = "m";
        long iD = 8306112507;
        uint uniqueNumber = 27560000;
      
        Console.WriteLine("First name:" + firstName);
        Console.WriteLine("Last name:" + lastName);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Gander:" + gander);
        Console.WriteLine("Personal ID number:" + iD);
        Console.WriteLine("Unique employee number:" + uniqueNumber);
      

    }
}
