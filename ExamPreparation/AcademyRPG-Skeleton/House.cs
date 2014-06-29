namespace AcademyRPG
{
    using System;
    using System.Linq;

    public class House : StaticObject
    {
        private const int DefaultHitPoints = 500;

        public House(Point position, int owner = 0) : base(position, owner)
        {
            this.HitPoints = DefaultHitPoints;
        }
    }
}