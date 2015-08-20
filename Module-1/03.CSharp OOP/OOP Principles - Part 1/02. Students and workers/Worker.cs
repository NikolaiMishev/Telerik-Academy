
namespace _02.Students_and_workers
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        
        private decimal workHoursPerDay;
        

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }

        public decimal MoneyPerHour
        {
            get
            {
                return this.WeekSalary / (this.workHoursPerDay * 5);
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            set
            {
                if (value > 24 || value < 1)
                {
                    throw new ArgumentException("The work hours are invalid!");
                }
                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("----------------------------------------");
            result.AppendLine("Name: " + this.FirstName + " " + this.LastName);
            result.AppendLine("Week Salary: " + this.WeekSalary);
            result.AppendLine("Work hours per day: " + this.WorkHoursPerDay);
           
            return result.ToString();
        }

        public decimal WeekSalary { get; private set; }
    }
}
