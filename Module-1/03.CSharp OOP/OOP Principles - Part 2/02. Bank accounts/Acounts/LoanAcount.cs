
namespace _02.Bank_accounts
{
    using System;

    public class LoanAcount : Acount, IDepositable
    {
        public LoanAcount(Customer customer, decimal balance, decimal intrest)
            : base(customer, balance, intrest)
        {

        }
        public override decimal CalcuklateIntrest(int numbOfMonts)
        {
            if (numbOfMonts < 0)
            {
                throw new ArgumentException("Number of months cannot be negative");
            }
            if (this.Customer is IndividualCustemer)
            {
                numbOfMonts -= 3;
            }
            else if (this.Customer is CompanyCustomer)
            {
                numbOfMonts -= 2;
            }
            if (numbOfMonts < 0)
            {
                return 0.0m;
            }
            return base.CalcuklateIntrest(numbOfMonts);

        }
    }
}
