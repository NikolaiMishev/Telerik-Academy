namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSM
    {
        private static GSM iphone4s = new GSM("Apple", "Iphone 4S", 200, "Ivaylo Kenov", new Battery("12RI/*290U", 200, 14, BatteryType.NiCd), new Display(3.5, 16));

        private string model;

        private string manifacturer;

        private int? price;

        private string owner;

        private List<Call> callHistory = new List<Call>();

        public GSM(string manifacturer, string model)
        {
            this.Manifacturer = manifacturer;
            this.Model = model;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public GSM(string manifacturer, string model, int price, string owner, Battery battery, Display display)
            : this(manifacturer, model)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM Iphone4S
        {
            get { return iphone4s; }
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
                    throw new ArgumentException("Model cannot be null or empty.");
                }

                this.model = value;
            }
        }

        public string Manifacturer
        {
            get 
            { 
                return this.manifacturer; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty.");
                }

                this.manifacturer = value;
            }
        }

        public int? Price
        {
            get 
            {
                return this.price; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be at least zero.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length < 2)
                    {
                        throw new ArgumentException("The name must be at least 6 symbolst!!!");
                    }
                }

                this.owner = value;
            }
        }

        public List<Call> CallHistory 
        { 
            get 
            { 
                return this.callHistory; 
            } 
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Manifacturer != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result.Append("Manufacturer".PadRight(20, ' '));
                result.Append(": " + this.Manifacturer);
                result.AppendLine();
            }

            if (this.Model != null)
            {
                result.Append("Model".PadRight(20, ' '));
                result.Append(": " + this.Model);
                result.AppendLine();
            }

            if (this.Price != null)
            {
                result.Append("Price".PadRight(20, ' '));
                result.Append(": " + this.Price + "$");
                result.AppendLine();
            }

            if (this.Owner != null)
            {
                result.Append("Owner".PadRight(20, ' '));
                result.Append(": " + this.Owner);
                result.AppendLine();
            }

            if (this.Battery != null)
            {
                result.Append("Battery".PadRight(20, ' '));
                result.Append(": " + this.Battery.Model);
                result.AppendLine();

                result.Append("  Type".PadRight(20, ' '));
                result.Append(": " + this.Battery.BateryType);
                result.AppendLine();
                if (this.Battery.IdleHours != null)
                {
                    result.Append("  IdleHours".PadRight(20, ' '));
                    result.Append(": " + this.Battery.IdleHours);
                    result.AppendLine();
                }

                if (this.Battery.TalkHours != null)
                {
                    result.Append("  TalkHours".PadRight(20, ' '));
                    result.Append(": " + this.Battery.TalkHours);
                    result.AppendLine();
                }
            }

            if (this.Display != null)
            {
                result.Append("Display:");
                result.AppendLine();
                if (this.Display.NumberOfColors != null)
                {
                    result.Append("  Number of Colors".PadRight(20, ' '));
                    result.Append(": " + this.Display.NumberOfColors + "M");
                    result.AppendLine();
                }

                if (this.Display.Size != null)
                {
                    result.Append("  Size".PadRight(20, ' '));
                    result.Append(": " + this.Display.Size + "inch");
                    result.AppendLine();
                }
            }

            return result.ToString();
        }

        public void AddCall(string date, string time, string dialedNumber, int duration)
        {
            this.CallHistory.Add(new Call(date, time, dialedNumber, duration));
        }

        public void RemoveCall(int index)
        {
            if ((this.CallHistory.Count <= index - 1) || (index - 1 < 0))
            {
                throw new ArgumentException("Call history log does not exists.");
            }

            this.CallHistory.RemoveAt(index - 1);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal TotalCallPrice(decimal pricePerMinute)
        {
            decimal result = 0;

            foreach (var call in this.callHistory)
            {
                result += (call.Duration * pricePerMinute) / 60;
            }

            return result;
        }

        public string ShowHistory()
        {
            StringBuilder result = new StringBuilder();

            foreach (var call in this.CallHistory)
            {
                result.AppendLine("Date: ".PadRight(15, ' ') + call.Date);
                result.AppendLine("Time: ".PadRight(15, ' ') + call.Time);
                result.AppendLine("Dialed number: ".PadRight(15, ' ') + call.DialedNumber);
                result.AppendLine("Call duration: ".PadRight(15, ' ') + call.Duration.ToString() + "sec");
                result.AppendLine();
            }

            if (result.Length == 0)
            {
                result.AppendLine("Call history is empty!!!");
            }

            return result.ToString();
        }
    }
}
