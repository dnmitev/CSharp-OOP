namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PowerCatalyst : Catalist
    {
        private const int DefaultPower = 3;

        public override int PowerEffect
        {
            get
            {
                return DefaultPower;
            }
        }
    }
}
