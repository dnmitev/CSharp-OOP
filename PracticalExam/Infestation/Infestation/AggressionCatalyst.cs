namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AggressionCatalyst : Catalist
    {
        private const int DefaultAggression = 3;

        public override int AggressionEffect
        {
            get
            {
                return DefaultAggression;
            }
        }
    }
}
