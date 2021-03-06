﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Method_PrintStatistics
{
    public class StatisticPrinter
    {
        public void PrintStatistics(double[] numbers)
        {
            Console.WriteLine("Statistics for : [" + string.Join(",",numbers) + "]");
            double smallestNumber = numbers.Min();
            this.PrintMin(smallestNumber);
            double largestNumber = numbers.Max();
            this.PrintMax(largestNumber);
            double average = numbers.Average();
            this.PrintAverage(average);
        }
        private void PrintMin(double smallestNumber)
        {
            Console.WriteLine("The smallest number is {0}.", smallestNumber);
        }

        private void PrintMax(double largestNumber)
        {
            Console.WriteLine("The largest number is {0}.", largestNumber);
        }

        private void PrintAverage(double average)
        {
            Console.WriteLine("The average of the numbers is {0}.", average);
        }
    }
}
