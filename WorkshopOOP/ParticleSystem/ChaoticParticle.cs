namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChaoticParticle : Particle
    {
        protected Random randomGenerator;

        private static readonly char[,] ChaoticParticleBody = new char[,] { { (char) 1 } };

        private const int AbsoluteSpeedDeviation = 1;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random rndGenerator)
            : base(position, speed)
        {
            this.randomGenerator = rndGenerator;
        }

        public override IEnumerable<Particle> Update()
        {
            // this will set the Particle prop Speed to 0,0
            this.Accelerate(new MatrixCoords(-this.Speed.Row, -this.Speed.Col));

            //this will add new random Speed
            this.Accelerate(GetRandomSpeed());

            return base.Update();
        }

        public override char[,] GetImage()
        {
            return ChaoticParticleBody;
        }

        protected virtual MatrixCoords GetRandomSpeed()
        {
            var randomSpeed = new MatrixCoords(
                this.randomGenerator.Next(-AbsoluteSpeedDeviation, AbsoluteSpeedDeviation + 1),
                this.randomGenerator.Next(-AbsoluteSpeedDeviation, AbsoluteSpeedDeviation + 1));

            return randomSpeed;
        }
    }
}