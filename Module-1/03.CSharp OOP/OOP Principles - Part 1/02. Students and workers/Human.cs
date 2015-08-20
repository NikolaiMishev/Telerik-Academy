
namespace _02.Students_and_workers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string LastName 
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name should not be empty!");
                }
                this.lastName = value;
            }
        }

        public string FirstName 
        { 
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name should not be empty!");
                }
                this.firstName = value;
            }
        }

    }
}
