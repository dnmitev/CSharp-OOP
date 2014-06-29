namespace Space3D
{
    using System.Collections.Generic;

    public class Path
    {
        // properties
        public List<Point3D> PathList { get; set; }

        // constructors
        public Path()
        {
            this.PathList = new List<Point3D>();
        }

        // methods
        public void AddPoint(Point3D point)
        {
            PathList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            PathList.Remove(point);
        }
    }
}
