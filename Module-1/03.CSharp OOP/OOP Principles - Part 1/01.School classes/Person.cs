namespace School
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : IComment
    {
        private string firstName;

        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.Comment = new List<string>();
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public List<string> Comment
        {
            get;
            set;
        }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

        public abstract override string ToString();
    }
}