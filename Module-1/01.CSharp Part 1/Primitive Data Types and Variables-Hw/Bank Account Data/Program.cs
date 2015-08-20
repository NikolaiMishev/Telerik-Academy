//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
//3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.

using System;

namespace Program
{
class Program
{
    static void Main()
    {
        String firstName="Nikolai";
        String middleName="Grigorov";
        String lastName="Mishev";
        decimal balance = 9155.55M;
        String bankName="BullBank";
        long iban = 123456789123456789;
        long creditCardNumberOne = 1234567891234567;
        long creditCardNumberTwo = 1234567891234567;
        long creditCardNumberTree = 1234567891234567;

        Console.WriteLine(firstName +middleName+lastName+balance+bankName+iban+creditCardNumberOne+creditCardNumberTwo+creditCardNumberTree);

       

    }
}
}
