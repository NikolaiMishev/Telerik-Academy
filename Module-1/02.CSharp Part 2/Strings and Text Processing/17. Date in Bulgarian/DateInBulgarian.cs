//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter date in format [day.month.year hour:minute:second]:");
        string startDate = Console.ReadLine();
       
        string format = "dd.MM.yyyy HH:mm:ss";
        DateTime dateTime;
        if (DateTime.TryParseExact(startDate, format, CultureInfo.InvariantCulture,
            DateTimeStyles.None, out dateTime))
        {
            dateTime = dateTime.AddHours(6).AddMinutes(30);

            Console.WriteLine("After 6 hours and 30 minutes: {0} - {1}", dateTime, dateTime.ToString("dddd"));
        }
    }
}