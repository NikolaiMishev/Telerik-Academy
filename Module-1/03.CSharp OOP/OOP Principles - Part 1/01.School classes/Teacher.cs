namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person
    {   
        private List<Discipline> teachersDisciplines;

        public Teacher(string firstName, string lastName)
              : base(firstName, lastName)
          {
              this.teachersDisciplines = new List<Discipline>();
              
          }
        public List<Discipline> TeachersDisciplines
        {
            get
            {
                return new List<Discipline>(this.teachersDisciplines);  //encapsulate and return new copy of the list
            }
        }

        public void AddDiscipline( Discipline disc)
        {
            this.teachersDisciplines.Add(disc);
        }

        public void RemoveDiscipline(string NameOFdisc)
        {

            foreach (var disc in this.teachersDisciplines)
            {
                if (disc.Name == NameOFdisc)
                {
                     this.teachersDisciplines.Remove(disc);
                     break;
                }
            }
        }

        public string ShowComents()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Comments:");
            foreach (var item in this.Comment)
            {
                result.AppendLine(item);
            }
            return result.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Teacher name: " + base.FirstName + " " + base.LastName);
            sb.AppendLine("Teacher disciplines: ");

            sb.AppendLine(string.Join(", ", TeachersDisciplines));

            return sb.ToString();
        }
    }
}
