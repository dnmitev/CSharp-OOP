namespace SoftwareAcademy
{
    using System;
    using System.Linq;
    using System.Text;

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string initialName, ITeacher tutor, string laboratory) : base(initialName, tutor)
        {
            this.Lab = laboratory;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Lab name cannot be null.");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendFormat("; Lab={0}", this.Lab);

            return result.ToString();
        }
    }
}