namespace School
{
    using System;
    using System.Linq;

    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Person name cannot be left empty.");
                }

                this.name = value;
            }
        }
    }
}