namespace StudentsExtraction
{
    using System;
    using System.Text;

    public class Student
    {
        private string name;
        private string groupName;

        public Student(string stName, string grName)
        {
            this.Name = stName;
            this.GroupName = grName;
        }

        public string GroupName
        {
            get
            {
                return groupName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Group name cannot be blank.");
                }

                this.groupName = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be blank.");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Name: " + this.Name);
            sb.AppendLine("Course: " + this.GroupName);

            return sb.ToString();
        }

    }
}
