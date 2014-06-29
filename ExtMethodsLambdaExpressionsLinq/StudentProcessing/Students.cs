// 9. Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), 
// GroupNumber. Create a List<Student> with sample students. Select only the students that are from 
// group number 2. Use LINQ query. Order the students by FirstName.

namespace StudentProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Students
    {
        private string firstName;
        private string lastName;
        private string facNum;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Students(string fName, string lName, string fn, string tel, string mail, List<int> marks, int grNum)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FacNum = fn;
            this.Tel = tel;
            this.Email = mail;
            this.Marks = marks;
            this.groupNumber = grNum;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group number cannot be zero or negative.");
                }

                this.groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("List of marks cannot be empty.");
                }

                this.marks = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be blank.");
                }

                this.email = value;
            }
        }

        public string Tel { get; private set; }

        public string FacNum
        {
            get
            {
                return this.facNum;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Department number cannot be blank.");
                }

                this.facNum = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last Name cannot be blank.");
                }

                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be blank.");
                }

                this.firstName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.FirstName + " " + this.LastName);
            sb.AppendLine("\tFN: " + this.FacNum);
            sb.AppendLine("\tTel: " + this.Tel);
            sb.AppendLine("\tEmail: " + this.Email);
            sb.AppendLine("\tMarks: " + string.Join(", ", this.Marks));
            sb.AppendLine("\tGroup Number: " + this.GroupNumber);

            return sb.ToString();
        }
    }
}