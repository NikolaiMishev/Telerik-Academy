
namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public class Discipline : IComment
    {
        private string name;
        private int exerciseNumber;
        private int lectureNumber;

        public Discipline(string name, int exerciseNumber, int lectureNumber)
        {
            this.Name = name;
            this.ExerciseNumber = exerciseNumber;
            this.LectureNumber = lectureNumber;
        }

        public string Name {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the discipline cannot be empty!");
                }
                this.name = value;
            }
        }

        public int ExerciseNumber 
        {
            get { return this.exerciseNumber; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of exercises have to be atleast 1 !!!");
                }
                this.exerciseNumber = value;
            }
        }

        public int LectureNumber 
        { 
            get { return this.lectureNumber; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of lectures  have to be atleast 1!");
                }
                this.lectureNumber = value;
            } 
        }

        public List<string> Comment { get; set; }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
