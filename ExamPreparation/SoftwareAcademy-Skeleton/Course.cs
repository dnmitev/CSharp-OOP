namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course : ICourse
    {
        private readonly ICollection<string> topics;

        private string name;

        public Course(string initialName, ITeacher tutor)
        {
            this.Name = initialName;
            this.Teacher = tutor;
            this.topics = new List<string>();
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
                    throw new ArgumentNullException("Course name cannot be null.");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);

            if (this.Teacher != null)
            {
                result.AppendFormat("; Teacher={0}; ", this.Teacher.Name);
            }

            if (this.topics.Count > 0)
            {
                result.AppendFormat("Topics=[{0}]", string.Join(", ", this.topics));
            }

            return result.ToString();
        }
    }
}