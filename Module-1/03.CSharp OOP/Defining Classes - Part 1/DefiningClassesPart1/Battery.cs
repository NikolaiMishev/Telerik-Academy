namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Battery
    {
        private string model;

        private int? idleHours;

        private int? talkHours;

        public Battery(string model, int? idleHours, int? talkHours, BatteryType batterytype)
            : this(model)
        {
            this.TalkHours = talkHours;
            this.IdleHours = idleHours;
            this.BateryType = batterytype;
        }

        public Battery(string model)
        {
            this.Model = model;
            this.TalkHours = null;
            this.IdleHours = null;
        }

        public BatteryType BateryType
        {
            get;
            set;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery model cannot be null or emtpy.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public int? IdleHours
        {
            get 
            { 
                return this.idleHours; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours must be at least zero.");
                }
                else
                {
                    this.idleHours = value;
                }
            }
        }

        public int? TalkHours
        {
            get 
            {
                return this.talkHours;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talk hours must be at least zero.");
                }
                else
                {
                    this.talkHours = value;
                }
            }
        }
    }
}
