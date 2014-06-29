namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Knight : Character, IFighter
    {
        private const int DefaultAttackPoints = 100;
        private const int DefaultDefensePoints = 100;
        private const int DefaultHitPoints = 100;

        public Knight(string name, Point position, int owner) : base(name, position, owner)
        {
            this.AttackPoints = DefaultAttackPoints;
            this.DefensePoints = DefaultDefensePoints;
            this.HitPoints = DefaultHitPoints;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints { get; private set; }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}