
namespace _03.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;

    public class ProgramMain
    {
        public static void Main()
        {


            Frog some = new Frog("froggy", Sex.Male, 2, "Forest Green");
            Console.WriteLine(some.Jump());

           
        }
    }
}
