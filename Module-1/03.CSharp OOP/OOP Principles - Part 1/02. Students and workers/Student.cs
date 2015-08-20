
namespace _02.Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student : Human
    {
        private byte grade;

        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }


        public byte Grade
        {
            get { return this.grade; }

            set
            {
                if (value > 12 | value < 1)
                {
                    throw new ArgumentException("There is no such grade!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("------------------------------");
            result.AppendLine("Name: " + this.FirstName + " " + this.LastName);
            result.AppendLine("Grade: " + this.grade);

            return result.ToString();
        }
    }
}
