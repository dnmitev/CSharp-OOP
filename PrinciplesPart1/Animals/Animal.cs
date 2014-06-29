namespace Animals
{
    using System;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private string name;
        private string sex;
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                this.age = value;
            }
        }

        public string Sex
        {
            get
            {
                return this.sex;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Animal's sex cannot be left blank.");
                }

                this.sex = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Animal's name cannot be left empty.");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\n\tSex: {1}\n\tAge: {2}", this.Name, this.Sex, this.Age);
        }

        public abstract void ProduceSound();
    }
}