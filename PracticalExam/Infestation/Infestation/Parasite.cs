namespace Infestation
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Parasite : Unit
    {
        private const int ParasitePower = 1;
        private const int ParasiteAggression = 1;
        private const int ParasiteHealth = 1;

        public Parasite(string id)
            : base(id, UnitClassification.Biological, ParasiteHealth, ParasitePower, ParasiteAggression)
        {
        }
    }
}
