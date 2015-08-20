namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    class Test
    {
        public static void Main()
        {
            var builder = new StringBuilder("StringBuilder in the house!");

            var subBuilder = builder.SubString(0, 13);

            Console.WriteLine(subBuilder);

        }
    }
}
