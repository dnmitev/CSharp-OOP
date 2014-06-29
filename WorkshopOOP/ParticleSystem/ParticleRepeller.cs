namespace ParticleSystem
{
    using System;
    using System.Linq;

    public class ParticleRepeller : Particle
    {
        private static readonly char[,] ParticleRepellerImage = new char[,] { { 'R' } };

        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int radiusOfEfectivity) : base(position, speed)
        {
            this.RadiusOfRepulsion = radiusOfEfectivity;
        }

        public int RadiusOfRepulsion { get; protected set; }

        public override char[,] GetImage()
        {
            return ParticleRepellerImage;
        }
    }
}