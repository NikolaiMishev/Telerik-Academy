namespace _06.Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        public static void Main()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 21, 49, 340, 459, 700, 1010, 66, 63 };
            Console.WriteLine("Numbers divisible by 3 and 7 at the same time.\n");
          
            Console.WriteLine("Result using Lambda expresions!\n" + LambdaExprResult(nums));
           
            Console.WriteLine("Result using LinqQuery!\n" + LinqQuerryResult(nums));
           
        }

        public static string LambdaExprResult(IList<int> arr)
        {
            string result = string.Join(",", arr.Where(x => x % 3 == 0 && x % 7 == 0));

            return result;
        }

        public static string LinqQuerryResult(IList<int> arr)
        {
           
            string result = string.Join(" ", from x in arr
                                          where x % 3 == 0 && x % 7 == 0
                                          select x);
            return result;
        }
    }
}
