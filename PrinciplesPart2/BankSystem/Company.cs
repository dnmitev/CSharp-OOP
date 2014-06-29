namespace BankSystem
{
    using System;
    using System.Linq;

    public class Company : Customer
    {
        public const int MortgageInterestPeriod = 12;

        public Company(string name) : base(name)
        {
        }
    }
}