using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_5.Students
{

    public class Test
    {
        static void Main()
        {
             Student[] students = new Student[3];
             students[0] = new Student("Nikolai", "Mishev", 22);
             students[1] = new Student("Pesho", "Gotsev", 25);
             students[2] = new Student("Anelia", "Ivanova", 19);

             Console.WriteLine("Problem 3:");
             var firstBeforeLast = FirstBeforeLast(students);
             Print(firstBeforeLast);

             Console.WriteLine("Problem 4:");
             var ageRange = AgeRange(students);
             Print(ageRange);

             Console.WriteLine("Problem 5:");
             var descending = DescendingOrder(students);
             Print(descending);
            
           
        }
        public static void Print(Student[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName+" "+ item.Age);
            }
        }

        public static Student[] DescendingOrder(Student[] students)
        {
            var ordered = from student in students
                          orderby student.FirstName ascending, student.LastName ascending
                          select student;
            return students.ToArray();
        }

        public static Student[] FirstBeforeLast(Student[] students)
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
