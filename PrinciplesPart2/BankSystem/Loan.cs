namespace BankSystem
{
    using System;
    using System.Linq;

    public class Loan : Account, IDeposit
    {
        public Loan(decimal balance, double interest, Customer client) : base(balance, interest, client)
        {
        }

        public override decimal CalculateInterest(int monthsCount)
        {
            if (this.Client is Individual)
            {
                monthsCount -= 3;
            }
            else if (this.Client is Company)
            {
                monthsCount -= 2;
            }

            if (monthsCount > 0)
            {
                return base.CalculateInterest(monthsCount);
            }

            return 0;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit negative amount of money into a loan.");
            }

            this.Balance += amount;
        }
    }
}