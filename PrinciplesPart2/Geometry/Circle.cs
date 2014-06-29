namespace Geometry
{
    using System;
    using System.Linq;

    public class Circle : Shape
    {
        public Circle(double diameter) : base(diameter, diameter)
        {
        }

        public override double CalculateSurface()
        {
            double area = Math.PI * (this.Height * this.Height) / 4;

            return area;
        }
    }
}