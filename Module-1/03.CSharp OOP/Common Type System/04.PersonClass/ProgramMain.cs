
namespace _04.PersonClass
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {
            Person firstPerson = new Person("Pesho", 25);
            Person secondPerson = new Person("Gerasim");
            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
