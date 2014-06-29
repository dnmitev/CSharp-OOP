namespace GeometryApi
{
    using System;
    using System.Linq;

    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        public Circle(Vector3D center, double circleRadius) : base(center)
        {
            this.Radius = circleRadius;
        }

        public double Radius { get; private set; }

        public double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }

        public Vector3D GetNormal()
        {
            Vector3D center = this.GetCenter();

            Vector3D A = new Vector3D(center.X + this.Radius, center.Y, center.Z);
            Vector3D B = new Vector3D(center.X, center.Y + this.Radius, center.Z);

            Vector3D normal = Vector3D.CrossProduct(center - A, center - B);
            normal.Normalize();

            return normal;
        }
    }
}