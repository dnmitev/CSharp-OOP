namespace AcademyEcosystem
{
    using System;
    using System.Linq;

    public class Deer : Animal, IHerbivore
    {
        private readonly int biteSize;

        public Deer(string name, Point location) : base(name, location, 3)
        {
            this.biteSize = 1;
        }

        public int EatPlant(Plant p)
        {
            if (p != null)
            {
                return p.GetEatenQuantity(this.biteSize);
            }

            return 0;
        }
    }
}