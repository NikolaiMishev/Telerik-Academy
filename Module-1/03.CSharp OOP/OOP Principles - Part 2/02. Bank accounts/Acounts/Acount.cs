
namespace _02.Bank_accounts
{
    using System;

    public abstract class Acount : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal intrest;

        public Acount(Customer customer, decimal balance,decimal intrest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Intrest = intrest;
        }
        public Customer Customer
        {
            get { return this.customer; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("");
                }
                this.customer = value;
            }
        }

        public decimal  Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                this.balance = value;
            }
        }

        public decimal Intrest 
        {
            get { return this.intrest; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                this.intrest = value;
            }
        }


        public void AddDeposit(decimal ammount)
        {
            this.Balance += ammount;
        }
        public virtual decimal CalcuklateIntrest(int numbOfMonts)
        {
            return (this.intrest/100)* numbOfMonts;
        }
    }
}
