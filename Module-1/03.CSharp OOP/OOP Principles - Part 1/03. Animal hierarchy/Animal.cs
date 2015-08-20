
namespace _03.Animal_hierarchy
{
    using System;

    public class Animal
    {
        private string name;

        private byte age;

        public Animal(string name, Sex sex, byte age, string type)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            this.Type = type;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name shoult not be empty!");
                }
                this.name = value;
            }
        }

        public Sex Sex { get; private set; }

        public byte Age
        {
            get { return this.age; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid age!");
                }
                this.age = value;
            }
        }

        public string Type { get; private set; }
    }
}
