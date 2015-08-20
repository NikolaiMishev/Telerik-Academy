namespace School
{
    using System;
    using System.Threading;

    public class Student : Person
    {
        private byte classNumber;

        public Student(string firstName, string lastName, byte classNumber)
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public byte ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Class number cannot be zero or negative number!");
                }
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " +  this.ClassNumber;
        }
    }
}