namespace MobilePhone
{
    using System;
    using System.Text;

    public class Display
    {
        // fields
        private double? size;
        private ulong? numberOfColors;

        // constructors
        public Display()
            : this(null, null)
        {
        }

        public Display(double? diagonal, ulong? colors)
        {
            this.Size = diagonal;
            this.NumberOfColors = colors;
        }

        // properties
        public double? Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The display size cannot be less than 0!");
                }

                this.size = value;
            }
        }

        public ulong? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The display colors cannot be less than 0!");
                }

                this.numberOfColors = value;
            }
        }

        // methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Size != null)
            {
                result.AppendFormat("\n\tSize: {0}\"", this.size);
            }

            if (this.NumberOfColors != null)
            {
                result.AppendFormat("\n\tNumber of colors: {0}", this.numberOfColors);
            }

            return result.ToString();
        }
    }
}