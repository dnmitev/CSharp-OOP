using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : Supplement
    {
        private const int DefaultPower = 10;
        private const int DefaultAggression = 3;

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
