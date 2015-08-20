namespace _17.Longes_String
{
    using System;
    using System.Linq;

    public class LongestString
    {
        static void Main()
        {
            var someStrings = new string[] { "O", "Oh", "Noo", "Oh Noo" };

            var result = (from str in someStrings 
                      orderby str.Length descending
                      select str).ToArray()[0];

            Console.WriteLine(result);
        }
    }
}
