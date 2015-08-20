using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Method_PrintStatistics
{
    public class TestStatisticPrinter
    {
        public static void Main()
        {
            StatisticPrinter statPrint = new StatisticPrinter();
            double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            statPrint.PrintStatistics(array);
        }
    }
}
