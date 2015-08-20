namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        private string dialedNumber;

        private int duration;

        public Call(string date, string time, string dialedNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public string Date { get; set; }

        public string Time { get; set; }

        public string DialedNumber
        {
            get 
            {
                return this.dialedNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone number cannot be null or empty.");
                }

                if (((value.Length != 10 && value.Length != 13) || (value.First() != '0' && value.First() != '+')))
                {
                    throw new ArgumentException("Phone number format is not properly set.");
                }

                this.dialedNumber = value;
            }
        }

        public int Duration
        {
            get 
            {
                return this.duration; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration must be at least zero.");
                }

                this.duration = value;
            }
        } 
    }
}
