//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Enter a date(in the future) in foramt[dd.mm.yyyy]: ");
        DateTime enddate = DateTime.Parse(Console.ReadLine());

        long workDays = FindWorkDays(enddate);
        Console.WriteLine("The work days from now to the date you entered are: {0}", workDays);
        
    }

    private static long FindWorkDays(DateTime enddate)
    {
        
            List<DateTime> publicHolydays = new List<DateTime>()
            {new DateTime(2015, 3, 1),new DateTime(2015, 3, 3),new DateTime(2015, 4, 2),
            new DateTime(2015, 4, 10), new DateTime(2015, 5, 2),new DateTime(2015, 5, 12),
            new DateTime(2015, 5, 16),new DateTime(2015, 6, 13),new DateTime(2015, 6, 15)};
            long workdaysCount = 0;
        DateTime current = DateTime.Now;
        while (current <= enddate)
        {
            if (!(publicHolydays.Contains(current) || (int)current.DayOfWeek == 0 || (int)current.DayOfWeek == 6))
            {
                workdaysCount++;
            }
            current = current.AddDays(1);
        }
        return workdaysCount;
    }
}
