
namespace _03.Animal_hierarchy
{
    using System;
    public class Frog : Animal , ISound
    {
        public string type;

        public Frog(string name, Sex sex, byte age, string type)
            : base(name,sex,age, type)
        {
            
        }

        public string Jump()
        {
         return string.Format("{0}, jumped into the water!", this.Name);
        }
        public void Sound()
        {
            Console.WriteLine("Quaq!");
        }
    }
}
