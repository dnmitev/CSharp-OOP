namespace AcademyEcosystem
{
    using System;
    using System.Linq;

    public class Lion : Animal, ICarnivore
    {
        private const int DefaultLionSize = 6;

        private const int SizeFactor = 2;

        public Lion(string initialName, Point position)
            : base(initialName, position, DefaultLionSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= SizeFactor * this.Size)
                {
                    this.Size++;
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
    }
}