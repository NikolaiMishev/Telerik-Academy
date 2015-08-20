//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        ChekIfLeap(year);
    }
    static void ChekIfLeap(int year)
    {
        Console.WriteLine("The year {0}->{1} leap!", year, DateTime.IsLeapYear(year) ? "IS" : "IS NOT");

    }
}