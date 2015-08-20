
namespace _02.Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramMain
    {
        static void Main()
        {
            //Students things
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", "Vasilev", 1));
            students.Add(new Student("Ignat", "Mamulev", 2));
            students.Add(new Student("Maalina", "Petrova", 11));
            students.Add(new Student("Suares", "Hepinho", 3));
            students.Add(new Student("Ester", "James", 5));
            students.Add(new Student("Nikolai", "Tadziki", 7));
            students.Add(new Student("Ivan", "Stefanov", 9));
            students.Add(new Student("Lidia", "Jeleva", 8));
            students.Add(new Student("Nikolina", "Nikolova", 12));
            students.Add(new Student("Danail", "Kichev", 4));

            var sortedStudentsByGrade = students.OrderBy(x => x.Grade);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorted students By grade:");
            Console.ResetColor();
            foreach (var st in sortedStudentsByGrade)
            {
                Console.WriteLine(st.ToString());
            }
           
            //Workers things
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Nikolai", "Sharanov", 300, 6));
            workers.Add(new Worker("Stefan", "Popov", 780, 8));
            workers.Add(new Worker("Nadq", "Shishmanova", 1000, 12));
            workers.Add(new Worker("Doncho", "Krasimirov", 500, 6));
            workers.Add(new Worker("Kalin", "Svilenov", 1200, 8));
            workers.Add(new Worker("Kamen", "Petrov", 460, 4));
            workers.Add(new Worker("Gancho", "Jelev", 950, 12));
            workers.Add(new Worker("Vilqn", "Borov", 1300, 8));
            workers.Add(new Worker("Robert", "Smith", 2000, 8));
            workers.Add(new Worker("Svilen", "Svilenov", 1700, 8));

            var sortedWorkersByMoneyPerHour = workers.OrderBy(x => x.MoneyPerHour);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorted students By grade:");
            Console.ResetColor();
            foreach (var wr in sortedWorkersByMoneyPerHour)
            {
                Console.WriteLine(wr.ToString());
             Console.WriteLine("Money per hour: {0:F2}",wr.MoneyPerHour);
            }

            //Merged things
            var mergedHumans = students
                .Concat<Human>(workers)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Merged list of all humans sorted by firstname and lastname:");
            Console.ResetColor();
            foreach (var human in mergedHumans)
            {
                Console.WriteLine("Name: {0} {1}",human.FirstName,human.LastName);
            }
        }
    }
}
