//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        string[] emails = text.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
        string[] validEmails = Array.FindAll(emails, IsValidEmail);
        foreach (var email in validEmails)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-{0}",email);
        }
        Console.ResetColor();
    }
    static bool IsValidEmail(string email)
    {
        const string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        return new Regex(pattern).IsMatch(email);
    }
}