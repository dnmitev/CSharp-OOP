namespace Space3D
{
    using System;

    public static class Distance
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double xR = first.X - second.X;
            double yR = first.Y - second.Y;
            double zR = first.Z - second.Z;

            double distance = Math.Sqrt(Math.Pow(xR, 2) + Math.Pow(yR, 2) + Math.Pow(zR, 2));

            return distance;
        }
    }
}
