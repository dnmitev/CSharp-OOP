namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RepulsionParticleUpdater : ParticleUpdater
    {
        private List<Particle> particles = new List<Particle>();
        private List<ParticleRepeller> repellers = new List<ParticleRepeller>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var repellerCandidate = p as ParticleRepeller;

            if (repellerCandidate == null)
            {
                this.particles.Add(p);
            }
            else
            {
                this.repellers.Add(repellerCandidate);
            }

            return base.OperateOn(p);
        }

        public override void TickEnded()
        {
            foreach (var repeller in repellers)
            {
                foreach (var particle in particles)
                {
                    if (this.IsInRadius(repeller, particle))
                    {
                        particle.Accelerate(this.InvertSpeed(particle));
                    }
                }
            }

            this.particles.Clear();
            this.repellers.Clear();

            base.TickEnded();
        }

        private MatrixCoords InvertSpeed(Particle p)
        {
            // store the current speed of the particle
            int particleSpeedByRow = p.Speed.Row;
            int particleSpeedByCol = p.Speed.Col;

            // set the particle's speed to 0,0
            p.Accelerate(new MatrixCoords(-p.Speed.Row, -p.Speed.Col));

            return new MatrixCoords(-particleSpeedByRow, particleSpeedByCol);
        }

        private bool IsInRadius(ParticleRepeller repeller, Particle particle)
        {
            double xDistance = Math.Pow(repeller.Speed.Row-particle.Speed.Row,2);
            double yDistance = Math.Pow(repeller.Speed.Col-particle.Speed.Col,2);

            double euclideanDistance = Math.Sqrt(xDistance + yDistance);

            if (euclideanDistance < repeller.RadiusOfRepulsion)
            {
                return true;
            }

            return false;
        }
    }
}
