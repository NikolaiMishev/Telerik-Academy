
namespace _02.Bank_accounts
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {
            CompanyCustomer companyCust = new CompanyCustomer("Gotinata firma");
            IndividualCustemer individualCust = new IndividualCustemer("Pesho");

            MorgageAcount individualMorg = new MorgageAcount(individualCust, 500, 5);
            DepositAcount individualDep = new DepositAcount(individualCust, 1200, 12);
            LoanAcount individualLoan = new LoanAcount(individualCust, 800, 5);

            MorgageAcount companyMorg = new MorgageAcount(companyCust, 3500, 18);
            DepositAcount companyDep = new DepositAcount(companyCust, 960, 7);
            LoanAcount companyLoan = new LoanAcount(companyCust, 1400, 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Individuals Accounts:");
            Console.ResetColor();

            Console.WriteLine("{0}'s accoint:\nCalkkulated deposit intrest:{1}\nDeposit: {2}",individualCust.Name,individualDep.CalcuklateIntrest(10),individualDep.Balance);
            Console.WriteLine("Calkkulated morgage intrest: {0}\nMorgage: {1}",individualMorg.CalcuklateIntrest(7), individualMorg.Balance);
            Console.WriteLine("Calkkulated loan intrest: {0}\nLoan: {1}",individualLoan.CalcuklateIntrest(9),individualLoan.Balance);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Companies Accounts:");
            Console.ResetColor();
            Console.WriteLine("{0}'s accoint:\nCalkkulated deposit intrest:{1}\nDeposit: {2}", companyCust.Name, companyDep.CalcuklateIntrest(10), companyDep.Balance);
            Console.WriteLine("Calkkulated morgage intrest: {0}\nMorgage: {1}", companyMorg.CalcuklateIntrest(7), companyMorg.Balance);
            Console.WriteLine("Calkkulated loan intrest: {0}\nLoan: {1}", companyLoan.CalcuklateIntrest(9), companyLoan.Balance);
           
            Bank someBank = new Bank();
            someBank.AddAcount(individualMorg);
            someBank.AddAcount(individualDep);
            someBank.AddAcount(individualLoan);
            someBank.AddAcount(companyMorg);
            someBank.AddAcount(companyDep);
            someBank.AddAcount(companyLoan);

        }
    }
}
