namespace Person
{
    using System;

    public class Person
    {
        private const string DefaultNullValue = "not specified";

        private string name;
        private byte? age;

        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name) : this(name, null)
        {
            this.Name = name;
        }

        public byte? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value > 150)
                {
                    throw new ArgumentException("This person seem to be really old");
                }

                this.age = value;
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
                    throw new ArgumentException("Name cannot be left blank.");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0}, Age: {1}", this.Name, DefaultNullValue);
            }
            else
            {
                return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
            }
        }
    }
}