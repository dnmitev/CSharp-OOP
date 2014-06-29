namespace FurnitureManufacturer.Models
{
    using System;

    public class Chair : Furniture, FurnitureManufacturer.Interfaces.IChair
    {
        private const int MinimalNumberOfChairLegs = 1;

        private int numberOfLegs;

        public Chair(string chairModel, string chairMaterial, decimal chairPrice, decimal chairHeight, int legsCount)
            : base(chairModel, chairMaterial, chairPrice, chairHeight)
        {
            this.NumberOfLegs = legsCount;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }

            private set
            {
                if (value < MinimalNumberOfChairLegs)
                {
                    throw new ArgumentOutOfRangeException("Number of chair's legs must be at least 3.");
                }
                else
                {
                    this.numberOfLegs = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", base.ToString(), string.Format(", Legs: {0}", this.NumberOfLegs));
        }
    }
}