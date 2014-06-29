namespace AcademyEcosystem
{
    using System;
    using System.Linq;

    public class Grass : Plant
    {
        private const int DefaulGrassSize = 2;
        private const int DefaultGrowStep = 1;

        public Grass(Point position) : base(position, DefaulGrassSize)
        {
        }

        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                this.Size += DefaultGrowStep;
            }

            base.Update(time);
        }
    }
}