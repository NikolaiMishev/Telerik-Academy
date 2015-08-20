
namespace _02.Bank_accounts
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("");
                }
                this.name = value;
            }
        }
    }
}
