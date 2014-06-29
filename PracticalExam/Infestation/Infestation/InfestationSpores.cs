namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class InfestationSpores : Supplement
    {
        private const int DefaultPower = -1;
        private const int DefaultAggression = 20;

        public override int AggressionEffect
        {
            get
            {
                return DefaultAggression;
            }

            protected set
            {
                base.AggressionEffect = value;
            }
        }

        public override int PowerEffect
        {
            get
            {
                return DefaultPower;
            }

            protected set
            {
                base.PowerEffect = value;
            }
        } 
    }
}
