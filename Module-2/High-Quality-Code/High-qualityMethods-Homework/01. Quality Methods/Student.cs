namespace _01.Quality_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   
    public class Student
    {
        private string firstname;

        private string lastname;

        private string otherInfo;

        public Student(string firstname, string lastname,DateTime birthDate, string info)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DateOfBirth = birthDate;
            this.OtherInfo = info;
        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                if (value == string.Empty || value.Length < 3)
                {
                    throw new ArgumentException("First name is not corect!");
                }
                this.firstname = value;
               
            } 
        }

        public string LastName 
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (value == string.Empty || value.Length < 3)
                {
                    throw new ArgumentException("Last name is not corect!");
                }

                this.lastname = value;
            } 
        }


        public DateTime DateOfBirth { get; set; }

        public string OtherInfo 
        {
            get
            {
                return this.otherInfo;
            }
            set
            {
                if(value == string.Empty || value.Length < 5 )
                {
                    throw new ArgumentException("The provided info is not corect!");
                }
                this.otherInfo = value;
            } 
        }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstDate = this.DateOfBirth;
            DateTime secondDate = otherStudent.DateOfBirth;

            return firstDate < secondDate;
        }
    }
}
