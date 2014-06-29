namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : ITeacher
    {
        private readonly ICollection<ICourse> courses;

        private string name;

        public Teacher(string initialName)
        {
            this.Name = initialName;
            this.courses = new List<ICourse>();
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
                    throw new ArgumentNullException("Teacher's name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Teacher: Name={0}", this.Name);

            if (this.courses.Count > 0)
            {
                result.AppendFormat("; Courses=[");

                foreach (var course in this.courses)
                {
                    result.AppendFormat("{0}, ", course.Name);
                }

                result.Length -= 2;

                result.AppendFormat("]");
            }

            return result.ToString();
        }
    }
}