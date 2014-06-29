namespace AcademyEcosystem
{
    using System;
    using System.Linq;

    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int DefaultBoarSize = 4;
        private const int DefaultBiteSize = 2;

        public Boar(string initialName, Point position)
            : base(initialName, position, DefaultBoarSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(DefaultBiteSize);
            }

            return 0;
        }
    }
}