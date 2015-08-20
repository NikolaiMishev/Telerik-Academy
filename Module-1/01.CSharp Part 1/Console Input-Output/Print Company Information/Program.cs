//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name,
//age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------Enter company information--------------");
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Company Phone Number:");
        int companyPhoneNumber = int.Parse(Console.ReadLine());
        Console.Write("Company fax number:");
        int companyFaxNumber = int.Parse(Console.ReadLine());
        Console.Write("Company web site:");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine("----------Enter Company manager information----------");
        Console.Write("Manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age:");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone number:");
        int managerPhoneNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------\t");
        Console.WriteLine(companyName + "\n" + companyAddress + "\n" + "tel. " + companyPhoneNumber + "\n" + "Fax:" + 
            companyFaxNumber + "\n" + "Company web site:" + companyWebSite);
        Console.WriteLine("Manager:" + managerFirstName + " " + managerLastName + "(age:" + managerAge + ", tel." + managerPhoneNumber);

    }
}
