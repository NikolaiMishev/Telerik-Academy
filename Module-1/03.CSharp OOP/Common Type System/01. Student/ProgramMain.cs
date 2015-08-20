/*
 * Problem 1: Define a class Student, which contains data about a student – first, middle and last name, SSN, 
    permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties,
    universities and faculties.
   Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * Problem 2: Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's 
    fields into a new object of type Student.
 * Problem 3: Implement the IComparable<Student> interface to compare students by names (as first criteria, in 
    lexicographic order) and by social security number (as second criteria, in increasing order).
 */
namespace _01.Student
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {
            Student firstStudent = new Student("Nikolai", "Stefanov", "Gerasimov", "9301139844", "Gr.Pirdop str.Malinska",
                                                "088811155874", "NStefG@abv.bg", 3, Specialty.KST, Faculty.FKSU,
                                                University.TuSofiq);
            Student secondStudent = new Student("Stefan", "Stefanov", "Nikolov", "9402237651", "Gr.Sofia str.PenchoSlaveikov",
                                                "0888175222","stefchoPicha@abv.bg", 3, Specialty.Mehatronika, Faculty.MF,
                                                 University.TuVarna);
            Student thirdStudent = secondStudent.Clone();

            bool chekSt = secondStudent == firstStudent;
            
            Console.WriteLine("Student 1: \n" + firstStudent.ToString());
            Console.WriteLine("Student 2: \n" + secondStudent.ToString());
            Console.WriteLine("Student 3: \n" + thirdStudent.ToString());
            Console.WriteLine("Do student1 match student2 : " + firstStudent.Equals(secondStudent));
            Console.WriteLine("Do student2 match student3 : " + secondStudent.Equals(thirdStudent));

            //Console.WriteLine(firstStudent == secondStudent);
            //Console.WriteLine(thirdStudent != firstStudent);
        }
    }
}
