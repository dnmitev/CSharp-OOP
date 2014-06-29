namespace BankSystem
{
    using System;
    using System.Linq;

    public class Mortgage : Account, IDeposit
    {
        public Mortgage(decimal balance, double interest, Customer client) : base(balance, interest, client)
        {
        }

        public override decimal CalculateInterest(int monthsCount)
        {
            if (this.Client is Company && monthsCount > Company.MortgageInterestPeriod)
            {
                monthsCount -= Company.MortgageInterestPeriod;

                decimal payment = base.CalculateInterest(Company.MortgageInterestPeriod / 2) + base.CalculateInterest(monthsCount);

                return payment;
            }
            else if (this.Client is Company)
            {
                return base.CalculateInterest(Company.MortgageInterestPeriod / 2);
            }
            else if (this.Client is Individual && monthsCount > Individual.MortgageInterestPeriod)
            {
                monthsCount -= Individual.MortgageInterestPeriod;

                return base.CalculateInterest(monthsCount);
            }

            return 0;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit negative amount of money into a mortgage.");
            }

            this.Balance += amount;
        }
    }
}