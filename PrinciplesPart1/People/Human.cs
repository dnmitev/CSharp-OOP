namespace People
{
    using System;
    using System.Linq;

    public abstract class Human
    {
        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}