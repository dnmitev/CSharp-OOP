namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Giant : Character, IFighter, IGatherer
    {
        private const int DefaultAttackPoints = 150;
        private const int DefaultDefensePoints = 80;
        private const int DefaultHitPoints = 200;

        private const int DefaultOwner = 0;

        private bool isImproved;

        public Giant(string name, Point position) : base(name, position, DefaultOwner)
        {
            this.AttackPoints = DefaultAttackPoints;
            this.DefensePoints = DefaultDefensePoints;
            this.HitPoints = DefaultHitPoints;

            this.isImproved = false;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints { get; private set; }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!this.isImproved)
                {
                    this.AttackPoints += 100;
                    this.isImproved = true;
                }

                return true;
            }

            return false;
        }
    }
}