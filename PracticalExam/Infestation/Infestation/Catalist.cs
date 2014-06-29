namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Catalist : Supplement
    {
        private const int DefaultAggression = 0;
        private const int DefaultPower = 0;
        private const int DefaultHealth = 0;


        public virtual int PowerEffect { get { return DefaultPower; } }

        public virtual int HealthEffect { get { return DefaultHealth; } }

        public virtual int AggressionEffect { get { return DefaultAggression; } }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}
