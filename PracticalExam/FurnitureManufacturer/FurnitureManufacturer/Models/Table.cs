namespace FurnitureManufacturer.Models
{
    using System;

    public class Table : FurnitureManufacturer.Models.Furniture, FurnitureManufacturer.Interfaces.ITable
    {
        private decimal lenght;
        private decimal width;

        public Table(string tableModel, string tableMaterial, decimal tablePrice, decimal tableHeight, decimal tableLength, decimal tableWidth)
            : base(tableModel, tableMaterial, tablePrice, tableHeight)
        {
            this.Length = tableLength;
            this.Width = tableWidth;
        }

        public decimal Length
        {
            get
            {
                return this.lenght;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Table's length must be a positive number.");
                }
                else
                {
                    this.lenght = value;
                }
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Table's width must be a positive number.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public decimal Area
        {
            get
            {
                decimal tableArea = this.Length * this.Width;

                return tableArea;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", base.ToString(), string.Format(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area));
        }
    }
}