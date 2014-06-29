namespace People
{
    using System;
    using System.Linq;

    public class Student : Human
    {
        private double grade;

        public Student(string fName, string lName, double grade)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }

             set
            {
                if (value < 2.0 || value > 6.0)
                {
                    throw new ArgumentException("Student's grade shall be between 2 and 6.");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n\tGrade: {1}", base.ToString(), this.Grade);
        }
    }
}