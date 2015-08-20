
namespace _02.Bank_accounts
{
    using System;

    public class MorgageAcount : Acount, IDepositable
    {
        public MorgageAcount(Customer customer, decimal balance, decimal intrest)
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
                numbOfMonts -= 6;
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (numbOfMonts <= 12)
                {
                    return 0.5m * base.CalcuklateIntrest(numbOfMonts);
                }
                else
                {
                    decimal result = 0.5m * base.CalcuklateIntrest(12);
                    result += base.CalcuklateIntrest(numbOfMonts - 12);
                    return result;
                }
            }
            if (numbOfMonts < 0)
            {
                return 0m;
            }

            return base.CalcuklateIntrest(numbOfMonts);
        }
    }
}
