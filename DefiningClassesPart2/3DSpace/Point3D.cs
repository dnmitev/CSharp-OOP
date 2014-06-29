namespace Space3D
{
    public struct Point3D
    {
        // fields
        private static readonly Point3D origin = new Point3D(0, 0, 0);

        private double x;
        private double y;
        private double z;

        // properties
        public static Point3D Origin 
        {
            get { return origin; } 
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        // constructors
        public Point3D(double xCoord, double yCoord, double zCoord)
        {
            this.x = xCoord;
            this.y = yCoord;
            this.z = zCoord;
        }

        // methods
        public override string ToString()
        {
            return string.Format("Point: {0}; {1}; {2}", this.X, this.Y, this.Z);
        }
    }
}
