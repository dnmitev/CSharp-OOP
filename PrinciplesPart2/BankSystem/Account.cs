namespace BankSystem
{
    using System;
    using System.Linq;

    public abstract class Account
    {
        private decimal balance;
        private double interestRate;
        private Customer client;

        public Account(decimal balance, double interest, Customer client)
        {
            this.Balance = balance;
            this.InterestRate = interest;
            this.Client = client;
        }

        public Customer Client
        {
            get
            {
                return this.client;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentException("Customer cannot be anonymous.");
                }

                this.client = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative.");
                }

                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new Exception("Account's balance cannot be negative.");
                }

                this.balance = value;
            }
        }

        public virtual decimal CalculateInterest(int monthsCount)
        {
            decimal earnedInterest = (decimal)(monthsCount * this.InterestRate);

            return earnedInterest;
        }

        public override string ToString()
        {
            return string.Format("Customer:{0}\n\tBalance: {1}\n\tInterest rate: {2}", this.Client, this.Balance, this.InterestRate);
        }
    }
}