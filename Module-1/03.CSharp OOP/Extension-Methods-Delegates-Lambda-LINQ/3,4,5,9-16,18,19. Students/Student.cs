namespace _3_4_5.Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
      
        public int Age { get; private set; }

        public Student(string firstname, string lastName, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Age = age;

        }

        public static  Student[] FirstBeforeLast(Student[] students)
        {
            var result = from st in students
                         where st.FirstName.CompareTo(st.LastName) < 0
                         orderby st.FirstName
                         select st;

            return result.ToArray();
        }

        public static Student[] AgeRange(Student[] students)
        {
            var result = from st in students
                         where st.Age >= 18 && st.Age <= 24
                         select st;

            return result.ToArray();
        }

    }
}
