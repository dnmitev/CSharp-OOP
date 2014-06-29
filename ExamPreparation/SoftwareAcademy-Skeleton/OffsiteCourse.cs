namespace SoftwareAcademy
{
    using System;
    using System.Linq;
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string initialName, ITeacher tutor, string city) : base(initialName, tutor)
        {
            this.Town = city;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Town cannot be null.");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}; ", base.ToString());
            result.AppendFormat("Town={0}", this.Town);

            return result.ToString();
        }
    }
}