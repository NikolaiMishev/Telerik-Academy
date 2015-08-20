//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter first date:");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter second date:");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        
        int counter = 0;
        while (startDate < endDate)
        {
            startDate = startDate.AddDays(1);
            counter++;
        }

        Console.WriteLine("Distance: {0} days!", counter);
    }

}
