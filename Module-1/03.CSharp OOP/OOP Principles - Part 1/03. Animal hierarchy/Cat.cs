
namespace _03.Animal_hierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, Sex sex, byte age, string type)
            : base(name, sex, age, type)
        {

        }
        public void Sound()
        {
            System.Console.WriteLine("Mew");
        }
    }
}
