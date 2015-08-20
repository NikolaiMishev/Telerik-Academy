namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            var test = new List<int>() { 4, 3, 2, 1};
            var test2 = new List<double>() { 1, 2, 3, 4 };
            Console.WriteLine(test2.Sum());
            Console.WriteLine(test.Product());
        }
    }
}
