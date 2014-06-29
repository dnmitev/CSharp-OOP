namespace MobilePhone
{
    using System;
    using System.Text;

    public class Call
    {
        // fields
        private int duration;

        // constructors 
        public Call(DateTime date, string number, int seconds)
        {
            this.DateAndTimeOfCall = date;
            this.DialedPhone = number;
            this.Duration = seconds;
        }

        // properties
        public DateTime DateAndTimeOfCall { get; private set; }

        public string DialedPhone { get; private set; }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Call duration cannot be less than 0.");
                }

                this.duration = value;
            }
        }

        // methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("\n\tDialed number: {0}", this.DialedPhone);
            result.AppendFormat("\n\tDate and time: {0}", this.DateAndTimeOfCall);
            result.AppendFormat("\n\tCall duration: {0} sec", this.Duration);

            return result.ToString();
        }
    }
}