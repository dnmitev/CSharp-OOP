namespace MobilePhone
{
    using System;
    using System.Text;

    public class Battery
    {
        // <fields>
        private double? hoursIdle;
        private double? hoursTalk;

        // <constructors>
        public Battery()
            : this(null, null, null, BatteryType.LiIon)
        {
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        // <properties>
        public string Model { get; private set; }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle should be more than 0!");
                }

                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk should be more than 0!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type { get; private set; }

        // <methods>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Model != null)
            {
                result.AppendFormat("\n\tModel: {0}", this.Model);
            }

            result.AppendFormat("\n\tBattery type: {0}", this.Type);

            if (this.HoursIdle != null)
            {
                result.AppendFormat("\n\tHours idle: {0}", this.HoursIdle);
            }

            if (this.HoursTalk != null)
            {
                result.AppendFormat("\n\tHours talk: {0}", this.HoursTalk);
            }

            return result.ToString();
        }
    }
}