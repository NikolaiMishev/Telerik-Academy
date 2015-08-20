
namespace _03.Animal_hierarchy
{
    using System;

    public class Dog : Animal, ISound
    {

        public Dog(string name, Sex sex, byte age, string type)
            : base(name, sex, age, type)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Bark Bark!");
        }
    }
}
