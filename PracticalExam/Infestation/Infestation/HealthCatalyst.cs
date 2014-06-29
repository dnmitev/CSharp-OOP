namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HealthCatalyst : Catalist
    {
        private const int DefaultHealth = 3;

        public override int HealthEffect
        {
            get
            {
                return DefaultHealth;
            }
        }
    }
}
