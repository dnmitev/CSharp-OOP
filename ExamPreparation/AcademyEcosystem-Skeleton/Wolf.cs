namespace AcademyEcosystem
{
    using System;
    using System.Linq;

    public class Wolf : Animal, ICarnivore
    {
        private const int DefaultWolfSize = 4;

        public Wolf(string initialName, Point position)
            : base(initialName, position, DefaultWolfSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size || animal.State == AnimalState.Sleeping)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
    }
}