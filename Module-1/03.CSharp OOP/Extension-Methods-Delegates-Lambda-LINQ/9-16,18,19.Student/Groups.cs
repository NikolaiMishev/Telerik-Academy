
namespace _9_16_18_19.Student
{
    using System;

    public class Group
    {
        public string DepartmentName { get; set; }

        public byte GroupNumber { get; set; }

        public Group(byte groupNumber, string department)
        {
            this.DepartmentName = department;
            this.GroupNumber = groupNumber;
        }
    }
}
