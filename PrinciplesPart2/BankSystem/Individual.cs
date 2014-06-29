namespace BankSystem
{
    using System;
    using System.Linq;

    public class Individual : Customer
    {
        public const int MortgageInterestPeriod = 6;

        public Individual(string name) : base(name)
        {
        }
    }
}