namespace _9_16_18_19.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
  
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FN { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public List<byte> Marks { get; private set; }
        public byte GroupNumber { get; private set; }

        public Student(string firstName, string lastName, string fn, string tel, byte group,List<byte> marks, string email = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = group;
        }

      
    }
}
