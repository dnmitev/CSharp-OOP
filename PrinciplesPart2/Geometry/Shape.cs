namespace Geometry
{
    using System;
    using System.Linq;

    public abstract class Shape
    {
        private double height;
        private double width;

        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get 
            { 
                return this.width; 
            }

            protected set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative.");
                }

                this.width = value; 
            }
        }

        public double Height
        {
            get 
            { 
                return this.height; 
            }

            protected set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative.");
                }

                this.height = value; 
            }
        }

        public abstract double CalculateSurface();
    }
}