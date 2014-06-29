namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Supplement : ISupplement
    {
        //private const int DefaultAggression = 0;
        //private const int DefaultPower = 0;
        //private const int DefaultHealth = 0;


        //public virtual int PowerEffect { get { return DefaultPower; } }

        //public virtual int HealthEffect { get { return DefaultHealth; } }

        //public virtual int AggressionEffect { get { return DefaultAggression; } }

        public virtual int PowerEffect { get; protected set; }

        public virtual int HealthEffect { get; protected set; }

        public virtual int AggressionEffect { get; protected set; }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}
