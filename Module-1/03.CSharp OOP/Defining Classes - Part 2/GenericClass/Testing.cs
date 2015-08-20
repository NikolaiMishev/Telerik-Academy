namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Testing
    {
        public static void Main()
        {
            GenericList<string> strings = new GenericList<string>(10);

            strings.AddElement("Nikolai");
            strings.AddElement("Mishev");
            Console.WriteLine(strings[0]+ "-" + strings[1]);
           
            Console.WriteLine(strings.Count.ToString());
            Console.WriteLine(strings.FindElement("Nilai"));
        }
    }
}
