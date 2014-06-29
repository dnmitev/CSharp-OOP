namespace Geometry
{
    using System;
    using System.Linq;

    public class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(h, w)
        {
        }

        public override double CalculateSurface()
        {
            double area = this.Width * this.Height;

            return area;
        }
    }
}