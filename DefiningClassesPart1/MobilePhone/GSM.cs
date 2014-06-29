namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static GSM iPhone4S;

        // fields
        private string model;
        private string manufacturer;
        private decimal? price;

        // constructors 
        static GSM()
        {
            Iphone4S =
                new GSM(
                    "Iphone 4S",
                    "Apple",
                    790m,
                    "Baba Kichka",
                    new Battery("BP-4l", 380, 6.5, BatteryType.LiIon),
                    new Display(4.2, 16000000));
        }

        public GSM(string modelGsm, string manufacturerGsm)
            : this(modelGsm, manufacturerGsm, null, null, null, null)
        {
            this.Model = modelGsm;
            this.Manufacturer = manufacturerGsm;
        }

        public GSM(string modelGsm, string manufacturerGsm, decimal priceGsm)
            : this(modelGsm, manufacturerGsm, priceGsm, null, null, null)
        {
            this.Model = modelGsm;
            this.Manufacturer = manufacturerGsm;
            this.Price = priceGsm;
        }

        public GSM(string modelGsm, string manufacturerGsm, decimal? priceGsm, string ownerGsm, Battery batt, Display disp)
        {
            this.Model = modelGsm;
            this.Manufacturer = manufacturerGsm;
            this.Price = priceGsm;
            this.Owner = ownerGsm;
            this.Battery = batt;
            this.Display = disp;

            this.CallHistory = new List<Call>();
        }

        // properties
        public static GSM Iphone4S
        {
            get
            {
                return iPhone4S;
            }

            set
            {
                iPhone4S = value;
            }
        }

        public List<Call> CallHistory { get; set; }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("GSM model cannot be null or white space.");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("GSM manufacturer cannot be null or white space.");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price < 0)
                {
                    throw new ArgumentException("The price cannot be negative.");
                }

                this.price = value;
            }
        }

        public string Owner { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        // methods
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            if (!this.CallHistory.Contains(call))
            {
                throw new ArgumentException("Current call not found in the call log.");
            }

            this.CallHistory.Remove(call);
        }

        public List<Call> ClearCallHistory()
        {
            List<Call> cleared = new List<Call>();

            this.CallHistory.Clear();

            cleared = this.CallHistory;

            return cleared;
        }

        public decimal CalculatePrice(decimal pricePerMinute)
        {
            if (pricePerMinute < 0)
            {
                throw new ArgumentException("The price per minute cannot be less than 0.");
            }

            decimal totalPrice = 0m;

            foreach (var call in this.CallHistory)
            {
                int minutes = call.Duration / 60;

                if (call.Duration % 60 != 0)
                {
                    minutes++;
                }

                totalPrice += pricePerMinute * minutes;
            }

            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Model: {0}\n", this.Model);
            result.AppendFormat("Manufacturer: {0}\n", this.Manufacturer);

            if (this.Price != null)
            {
                result.AppendFormat("Price: {0}\n", this.Price);
            }

            if (this.Owner != null)
            {
                result.AppendFormat("Owner: {0}\n", this.Owner);
            }

            if (this.Battery != null)
            {
                result.AppendFormat("Battery: {0}\n", this.Battery);
            }

            if (this.Display != null)
            {
                result.AppendFormat("Display: {0}\n", this.Display);
            }

            return result.ToString();
        }
    }
}