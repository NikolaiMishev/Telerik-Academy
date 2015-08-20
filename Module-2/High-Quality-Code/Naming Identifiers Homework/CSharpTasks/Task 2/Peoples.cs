namespace Task_2
{
    using System;

    public class Peoples
    {
        static void Main(string[] args)
        {
            Person femalePerson = new Person();
            femalePerson = femalePerson.ConfigurePerson(32);

            Person malePerson = new Person();
            malePerson = malePerson.ConfigurePerson(23);

            Console.WriteLine(malePerson + "\n" + femalePerson);
        }
    }
}
