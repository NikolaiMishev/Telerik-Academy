namespace Task_2
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, int age, Gender gender) : this()
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public Gender Gender { get; private set; }

        public Person ConfigurePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Gender = Gender.male;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Gender = Gender.female;
            }

            return newPerson;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + " " + this.Gender;
        }
    }
}
