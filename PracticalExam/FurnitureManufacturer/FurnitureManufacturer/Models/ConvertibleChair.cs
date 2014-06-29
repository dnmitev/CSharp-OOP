namespace FurnitureManufacturer.Models
{
    using System;
    using System.Linq;

    public class ConvertibleChair : Chair, FurnitureManufacturer.Interfaces.IConvertibleChair
    {
        private static readonly string ConvertedState = "Converted";
        private static readonly string NormalState = "Normal";

        private const decimal ConvertedHeight = 0.10m;

        public ConvertibleChair(string convertibleChairModel, string convertibleChairMaterial, decimal convertibleChairPrice, decimal convertibleChairHeight, int convertibleChairLegsCount)
            : base(convertibleChairModel, convertibleChairMaterial, convertibleChairPrice, convertibleChairHeight, convertibleChairLegsCount)
        {
            this.IsConverted = false; // initially the chair is NOT converted
        }

        public bool IsConverted { get; private set; }

        public override decimal Height
        {
            get
            {
                if (this.IsConverted)
                {
                    return ConvertedHeight;
                }
                else
                {
                    return base.Height;
                }
            }

            protected set
            {
                base.Height = value;
            }
        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            string currentState = this.IsConverted ? ConvertedState : NormalState;

            return string.Format("{0}{1}", base.ToString(), string.Format(", State: {0}", currentState));
        }
    }
}