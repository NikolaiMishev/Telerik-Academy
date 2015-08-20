using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_16_18_19.Student
{
    class Test
    {
        public static List<Student> StudentsFromGroup2(List<Student> students)
        {
            var result = from st in students
                         where st.GroupNumber == 2
                         orderby st.FirstName
                         select st;
            return result.ToList();

        }

        public static void Print(List<Student> students)
        {

            foreach (var item in students)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Name: " + item.FirstName + " " + item.LastName);
                Console.WriteLine("Fn: " + item.FN);
                Console.WriteLine("Tel: " + item.Tel);
                Console.WriteLine("Goup: " + item.GroupNumber);
                Console.WriteLine("Grades: " + string.Join(",", item.Marks.ToArray()));
                Console.WriteLine("Email: " + item.Email);
            }
        }

        public static List<Student> StudentsWithAbvEmails(List<Student> students)
        {
            var result = from st in students
                         where st.Email.Substring(st.Email.IndexOf('@'), st.Email.Length - st.Email.IndexOf("@")) == "@abv.bg"
                         select st;
            return result.ToList();
        }

        public static List<Student> StudentsWithPhonesInSofiq(List<Student> students)
        {
            var result = from st in students
                         where st.Tel.Substring(0, 2) == "02"
                         select st;
            return result.ToList();
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Alisa", "Petrova", "121206", "0889445111", 3, new List<byte> { 6, 5 }, "alisa1@abv.bg"));
            students.Add(new Student("Nencho", "Simeonov", "121206", "02669874", 1, new List<byte> { 4, 3, 3, 6, 3 }, "nen4o@mail.bg"));
            students.Add(new Student("Simeon", "Stalinov", "123451", "0998774442", 4, new List<byte> { 3, 3, 3, 2, 2 }, "simo98@gmail.bg"));
            students.Add(new Student("Todor", "Enikov", "124211", "02987475", 2, new List<byte> { 2, 4, 3, 5, 2 }, "moqS@abv.bg"));
            students.Add(new Student("Reni", "Petrova", "124406", "08971394567", 1, new List<byte> { 3, 3, 6, 6, 4 }, "Makarof33@abv.bg"));
            students.Add(new Student("Radomir", "Kaunov", "123341", "08877985478", 2, new List<byte> { 4, 4 }, "radoShisha@yahoo.bg"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 9: Students from group 2!");
            Console.ResetColor();
            var studentsFromGroup2 = StudentsFromGroup2(students);
            Print(studentsFromGroup2);
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 10: Students from group 2-->Extension Method!!!!!!!!!!!!");
            Console.ResetColor();
            var studentsExt = students.StudentsFromGroup2Ext();
            Print(studentsExt);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 11: Students with emails in ABV.bg!");
            Console.ResetColor();
            var studentsWithAbvEmails = StudentsWithAbvEmails(students);
            Print(studentsWithAbvEmails);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 12: Students with phones in Sofiq!");
            Console.ResetColor();
            var studentsWithPhonesInSofiq = StudentsWithPhonesInSofiq(students);
            Print(studentsWithPhonesInSofiq);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 13: Students that have mark 6 !");
            Console.ResetColor();
            var studentsWithMark6 = from st in students
                                    where st.Marks.Contains(6)
                                    select new { FullName = st.FirstName + " " + st.LastName, Marks = string.Join(",", st.Marks) };
            Console.WriteLine();
            foreach (var student in studentsWithMark6)
            {
                Console.WriteLine("Name: {0}\nMarks: {1}", student.FullName, student.Marks);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 14: Students that have exactly two marks!");
            Console.ResetColor();
            var studentsWith2Marks = students.Where(st => st.Marks.Count == 2).ToList();
            Print(studentsWith2Marks);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 15: All marks of the students that enrolled in 2006!");
            Console.ResetColor();
            foreach (var st in students)
            {
                if (st.FN.EndsWith("06"))
                {
                    Console.Write(string.Join(",", st.Marks));
                    Console.Write(",");
                }
            }
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 16: Students From Mathematics!");
            Console.ResetColor();
            Group[] groups = new Group[]{ 
                new Group(1, "Mathematics"),
                new Group(2, "History"),
                new Group(3, "Physics"),
                new Group(4, "Programming")};

            var studentsGroups = from st in students
                                 join d in groups on st.GroupNumber equals d.GroupNumber
                                 where st.GroupNumber == 1
                                 select st;
            Print(studentsGroups.ToList());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 18: Students grouped by group numbers USING LINQ QUERY!");
            Console.ResetColor();
            foreach (var gr in groups)
            {
                var studentsByGroups = from st in students
                                       where st.GroupNumber == gr.GroupNumber
                                       select st;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(gr.DepartmentName);
                Console.ResetColor();
                Print(studentsByGroups.ToList());
            }
            Console.WriteLine();

            var groupedStudentsExtensions = students.GroupBy(s => s.GroupNumber);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 19: Grouping by GroupNumber using extensions!");
            Console.ResetColor();

            foreach (var group in groupedStudentsExtensions)
            {
                Print(group.ToList());
            }


        }
    }
}
