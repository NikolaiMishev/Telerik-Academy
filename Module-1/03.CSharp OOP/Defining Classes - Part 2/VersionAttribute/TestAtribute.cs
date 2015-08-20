namespace VersionAttribute
{
    using System;

    [VersionAttribute("1.8")]
    class TestAtribute
    {
        static void Main()
        {
            Type type = typeof(TestAtribute);

            var attribute = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attribute)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine("Version[{0}.{1}]", item.Major, item.Minor);
            }
        }
    }
}
