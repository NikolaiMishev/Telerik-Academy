
namespace _01.Student
{
    using System;
using System.Text;

    public class Student : IClonable , IComparable<Student>
    {
        //fields
        private string firstName;

        private string middleName;

        private string lastName;

        private string sSN;

        private string permAdress;

        private string mobilePhone;

        private string email;

        private byte course;

        //Ctor
        public Student(string firstName, string middleName, string lastName, string sSN, string address,
                       string phone, string email, byte course, Specialty spec, Faculty fac, University uni)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.PermanentAdres = address;
            this.MobylePhone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = spec;
            this.Faculty = fac;
            this.University = uni;
        }

        //property's
        public byte Course
        {
            get
            {
                if (this.course <= 0)
                {
                    throw new ArgumentException("This course is not valid!!");
                }
                return this.course;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("This course is not valid!!");
                }
                this.course = value;
            }
        }

        public string Email
        {
            get
            {
                if (string.IsNullOrEmpty(this.email))
                {
                    throw new ArgumentException("No email!");
                }
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Not valid email!");
                }
                this.email = value;
            }
        }

        public string MobylePhone
        {
            get
            {
                if (string.IsNullOrEmpty(this.mobilePhone))
                {
                    throw new ArgumentException("No mobile Phone");
                }
                return this.mobilePhone;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Not valid mobile Phone!");
                }
                this.mobilePhone = value;
            }
        }

        public string PermanentAdres
        {
            get
            {
                if (string.IsNullOrEmpty(this.permAdress))
                {
                    throw new ArgumentException("No address!");
                }
                return this.permAdress;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Not valid addres !");
                }
                this.permAdress = value;
            }
        }

        public string SSN
        {
            get
            {
                if (string.IsNullOrEmpty(this.sSN))
                {
                    throw new ArgumentException("No SSN !");
                }
                return this.sSN;
            }
            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("SSN not valid !!!");
                }
                this.sSN = value;
            }
        }

        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(this.lastName))
                {
                    throw new ArgumentException("No last name");
                }
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Not valid last name! ");
                }
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                if (string.IsNullOrEmpty(this.middleName))
                {
                    throw new ArgumentException("No middle name");
                }
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Not valid middle name!!!");
                }
                this.middleName = value;
            }
        }

        public string FirstName
        {
            get
            {
                if (string.IsNullOrEmpty(this.firstName))
                {
                    throw new ArgumentException("No first name");
                }
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Not valid first name!!!");
                }
                this.firstName = value;
            }
        }

        public Specialty Specialty { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        //method's

        public override bool Equals(Object obj)
        {
            var student = obj as Student;

            bool result = false;
            if (
                   this.FirstName.Equals(student.FirstName) 
                && this.MiddleName.Equals(student.MiddleName) 
                && this.LastName.Equals(student.LastName) 
                && this.SSN.Equals(student.SSN)
                && this.PermanentAdres.Equals(student.PermanentAdres)
                && this.MobylePhone.Equals(student.MobylePhone)
                && this.Email.Equals(student.Email)
                && this.Course.Equals(student.Course)
                && this.University.Equals(student.University)
                && this.Faculty.Equals(student.Faculty)
                && this.Specialty.Equals(student.Specialty))
            {
                result = true;
            }

            return result;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SSN.GetHashCode() ^ this.MobylePhone.GetHashCode() ^ this.Faculty.GetHashCode() ^ this.Email.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Name:         " + this.FirstName + " " + this.MiddleName + " " + this.LastName);
            result.AppendLine("SSN:          " + this.SSN);
            result.AppendLine("Address:      " + this.PermanentAdres);
            result.AppendLine("Mobile phone: " + this.MobylePhone);
            result.AppendLine("Email:        " + this.Email);
            result.AppendLine("Course:       " + this.Course);
            result.AppendLine("University:   " + this.University);
            result.AppendLine("Faculty:      " + this.Faculty);
            result.AppendLine("Specialty :   " + this.Specialty);
                return result.ToString();
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }
        public static bool operator !=(Student st1, Student st2)
        {
            return !(st1.Equals(st2));
        }

        public Student Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN,
                                         this.PermanentAdres, this.MobylePhone,this.Email, this.Course,
                                         this.Specialty, this.Faculty, this.University);
            return result;
        }

        public int CompareTo(Student other)
        {
            var nameOfStudent = this.FirstName + this.MiddleName + this.LastName;
            var nameOfOther = other.FirstName + other.MiddleName + other.LastName;

            if (nameOfStudent == nameOfOther)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return nameOfStudent.CompareTo(nameOfOther);
        }
    }
}
