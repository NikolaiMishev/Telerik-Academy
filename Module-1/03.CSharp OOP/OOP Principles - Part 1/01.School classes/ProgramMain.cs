namespace School
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {
            //Students
            Student firstStudent = new Student("Pesho", "Kamburov", 1);
            Student secondStudent = new Student("Galin", "Imamov", 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students:");
            Console.ResetColor();
            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(secondStudent.ToString());
            //Teachers
            Teacher firstTeacher = new Teacher("Stefan", "Popov");
            firstTeacher.AddDiscipline(new Discipline("Math", 16, 10));
            firstTeacher.AddDiscipline(new Discipline("Physics", 20, 5));
            Teacher secondTeacher = new Teacher("Armin", "Van Buuren");
            secondTeacher.AddDiscipline(new Discipline("TechMusic", 15, 5));
            secondTeacher.AddDiscipline(new Discipline("Minimal", 18, 7));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTeachers:");
            Console.ResetColor();
            Console.WriteLine(firstTeacher.ToString());
            Console.WriteLine(secondTeacher.ToString());


            //School
            School school = new School();

            school.AddClass(new Class("12b", firstTeacher));
            school.AddClass(new Class("12a", secondTeacher));
        }
    }
}
