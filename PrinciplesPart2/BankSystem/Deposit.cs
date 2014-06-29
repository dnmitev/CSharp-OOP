namespace BankSystem
{
    using System;
    using System.Linq;

    public class Deposit : Account, IDeposit, IWithdraw
    {
        public Deposit(decimal balance, double interest, Customer client) : base(balance, interest, client)
        {
        }

        public override decimal CalculateInterest(int monthsCount)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(monthsCount);
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit negative amount of money into a deposit.");
            }

            this.Balance += amount;
        }

        public void DrawMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot draw negative amount of money.");
            }
            else if (this.Balance < amount)
            {
                throw new ArgumentException("Not enough money in the account.");
            }
            else
            {
                this.Balance -= amount;
            }
        }
    }
}