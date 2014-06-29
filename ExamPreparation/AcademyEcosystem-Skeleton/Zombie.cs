namespace AcademyEcosystem
{
    using System;
    using System.Linq;

    public class Zombie : Animal
    {
        private const int DefaultZombieSize = 0;
        private const int DefaultZombieProvidenMeat = 10;

        public Zombie(string zombieName, Point position) : base(zombieName, position, DefaultZombieSize)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            return DefaultZombieProvidenMeat;
        }
    }
}