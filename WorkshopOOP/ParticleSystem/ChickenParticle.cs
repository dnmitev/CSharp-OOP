using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private static readonly char[,] ChickenParticleBody = new char[,] { { (char)11 } };
        private static readonly MatrixCoords Stop = new MatrixCoords(0, 0);

        private const double ChanceToStop = 0.5;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random rndGenerator)
            : base(position, speed, rndGenerator)
        {
        }

        public override char[,] GetImage()
        {
            return ChickenParticleBody;
        }

        public override IEnumerable<Particle> Update()
        {
            if (this.Speed.Equals(ChickenParticle.Stop))
            {
                var baseParticles = base.Update();

                var newChicken = new List<Particle>(baseParticles);

                newChicken.Add(new ChickenParticle(this.Position, ChickenParticle.Stop, this.randomGenerator));

                return newChicken;
            }
            return base.Update();
        }

        protected override MatrixCoords GetRandomSpeed()
        {
            if (this.randomGenerator.Next(0, 101) < ChanceToStop)
            {
                return ChickenParticle.Stop;
            }
            else
            {
                return base.GetRandomSpeed();
            }
        }

    }
}
