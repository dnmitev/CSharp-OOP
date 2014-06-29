namespace Geometry
{
    using System;
    using System.Linq;

    public class Triangle : Shape
    {
        public Triangle(double h, double w) : base(h, w)
        {
        }

        public override double CalculateSurface()
        {
            double area = this.Width * this.Height / 2;

            return area;
        }
    }
}