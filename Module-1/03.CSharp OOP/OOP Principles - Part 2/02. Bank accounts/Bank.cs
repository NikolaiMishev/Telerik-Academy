
namespace _02.Bank_accounts
{
    using System;
    using System.Collections.Generic;

    public class Bank
    {
        private List<Acount> acounts;

        public Bank()
        {
            this.acounts = new List<Acount>();
        }
        public List<Acount> Acounts
        {
            get { return new List<Acount>(this.acounts); }
            private set
            {
                this.acounts = value;
            }
        }

        public void AddAcount(Acount acc)
        {
            this.acounts.Add(acc);
        }
        public void RemoveAcount(Acount acc)
        {
            this.acounts.Remove(acc);
        }
    }
}
