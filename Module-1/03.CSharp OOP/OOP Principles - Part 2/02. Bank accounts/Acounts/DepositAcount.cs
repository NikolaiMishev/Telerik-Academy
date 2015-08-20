
namespace _02.Bank_accounts
{
    using System;

    public class DepositAcount : Acount, IWithDrawable, IDepositable
    {
        public DepositAcount(Customer customer, decimal balance, decimal intrest)
            : base(customer, balance, intrest)
        {

        }

        public void WithDrawAmmount(decimal ammount)
        {
            if (ammount> this.Balance)
            {
                throw new ArgumentException("Not enough money!");
            }
            this.Balance -= ammount;
        }

        public override decimal CalcuklateIntrest(int numbOfMonts)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return base.CalcuklateIntrest(numbOfMonts);
        }

    }
}
