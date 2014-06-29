﻿namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ninja : Character, IFighter, IGatherer
    {
        private const int InitialAttackPoints = 0;
        private const int DefaultHitPoints = 1;

        public Ninja(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = DefaultHitPoints;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints
        {
            get
            {
                return int.MaxValue;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0 && availableTargets[i].HitPoints == availableTargets.Max((hp) => hp.HitPoints))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }

            return false;
        }
    }
}