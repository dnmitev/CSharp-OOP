namespace FurnitureManufacturer.Models
{
    using System;

    public abstract class Furniture : FurnitureManufacturer.Interfaces.IFurniture
    {
        private const int MinimalModelStringLength = 3;

        private string model;
        private string material;
        private decimal price;
        private decimal height;

        protected Furniture(string furnitureModel, string furnitureMaterial, decimal furniturePrice, decimal furnitureHeight)
        {
            this.Model = furnitureModel;
            this.Material = furnitureMaterial;
            this.Price = furniturePrice;
            this.Height = furnitureHeight;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Furniture model cannot be null or empty");
                }
                else if (value.Length < MinimalModelStringLength)
                {
                    throw new ArgumentOutOfRangeException("Furniture model must be longer than 3 symbols.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Furniture material cannot be null or empty.");
                }
                else
                {
                    this.material = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Furniture price must be greater than $0.00.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Furniture height must be greater than 0.00m.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}