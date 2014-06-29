namespace GeometryApi
{
    using System;
    using System.Linq;

    public class Cylinder : Figure, IVolumeMeasurable, IAreaMeasurable
    {
        public Cylinder(Vector3D bottomCenter, Vector3D topCenter, double radius) : base(bottomCenter, topCenter)
        {
            this.Radius = radius;
        }

        public Vector3D Bottom
        {
            get
            {
                return new Vector3D(this.vertices[0].X, this.vertices[0].Y, this.vertices[0].Z);
            }

            private set
            {
                this.vertices[0] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        public Vector3D Top
        {
            get
            {
                return new Vector3D(this.vertices[1].X, this.vertices[1].Y, this.vertices[1].Z);
            }

            private set
            {
                this.vertices[1] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        public double Radius { get; private set; }

        public double GetVolume()
        {
            double baseArea = Math.PI * this.Radius * this.Radius;
            double height = (this.Top - this.Bottom).Magnitude;
            double volumeOfCylinder = baseArea * height;

            return volumeOfCylinder;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }

        public double GetArea()
        {
            double basePerimeter = 2 * Math.PI * this.Radius;
            double height = (this.Top - this.Bottom).Magnitude;
            double baseArea = Math.PI * this.Radius * this.Radius;
            double sideArea = basePerimeter * height;

            double area = baseArea * 2 + sideArea;

            return area;
        }
    }
}