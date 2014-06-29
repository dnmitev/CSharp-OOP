namespace People
{
    using System;
    using System.Linq;

    internal class Worker : Human
    {
        private const int WorkDays = 5;

        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string fName, string lName, decimal salary, int workHours)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHours;
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Working hours per day cannot be negative.");
                }

                if (value > 24)
                {
                    throw new ArgumentException("One day has no more than 24 hours.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The week salary cannot be negative.");
                }

                this.weekSalary = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerDay = this.WeekSalary / WorkDays;
            decimal moneyPerHour = moneyPerDay / WorkHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0}\n\tWeek salary: {1}\n\tWork hours per day: {2}\n\tMoney per hour: {3:F2}",
                base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}