// 01.Create a ChaoticParticle class, which is a Particle, randomly changing its movement (Speed). 
// You are not allowed to edit any existing class.

// 02. Test the ChaoticParticle through the ParticleSystemMain class

// 03.Create a ChickenParticle class. The ChickenParticle class moves like a ChaoticParticle, but 
// randomly stops at different positions for several simulation ticks and, for each of those stops, 
// creates (lays) a new ChickenParticle. You are not allowed to edit any existing class.

// 04.Test the ChickenParticle class through the ParcticleSystemMain class.

// 05.Implement a ParticleRepeller class. A ParticleRepeller is a Particle, which pushes other
// particles away from it (i.e. accelerates them in a direction, opposite of the direction in 
// which the repeller is). The repeller has an effect only on particles within a certain radius 
// (see Euclidean distance)

// 06.Test the ParticleRepeller class through the ParticleSystemMain class

namespace ParticleSystem
{
    using System;
    using System.Linq;

    public class ParticleSystemMain
    {
        const int Rows = 30;
        const int Cols = 60;

        static readonly Random randomGenerator = new Random();

        static void Main()
        {
            var renderer = new ConsoleRenderer(Rows, Cols);

            var particleOperator = new AdvancedParticleOperator();

            var engine =
                new Engine(renderer, particleOperator, null, 300);

            GenerateInitialData(engine);

            GenerateChaoticParticles(engine);

            //GenerateChickenParticles(engine);

            GenerateParticleRepeller(engine);

            engine.Run();
        }

        private static void GenerateParticleRepeller(Engine engine)
        {
            var repeller = new ParticleRepeller(
                new MatrixCoords(15, 15),
                new MatrixCoords(0, 0),
                2);

            engine.AddParticle(repeller);
        }

        private static void GenerateChickenParticles(Engine engine)
        {
            var chickens = new ChickenParticle(
                new MatrixCoords(15,15),
                new MatrixCoords(1, 1),
                randomGenerator);

            engine.AddParticle(chickens);
        }

        private static void GenerateChaoticParticles(Engine engine)
        {
            var chaoticParticle = new ChaoticParticle(
                new MatrixCoords(10, 10),
                new MatrixCoords(-1, 1),
                randomGenerator);

            engine.AddParticle(chaoticParticle);
        }

        private static void GenerateInitialData(Engine engine)
        {
            //engine.AddParticle(
            //    new Particle(
            //        new MatrixCoords(0, 8),
            //        new MatrixCoords(-1, 0)));
            //engine.AddParticle(
            //    new DyingParticle(
            //        new MatrixCoords(20, 5),
            //        new MatrixCoords(-1, 1),
            //        12));
            var emitterPosition = new MatrixCoords(29, 0);
            var emitterSpeed = new MatrixCoords(0, 0);
            var emitter = new ParticleEmitter(emitterPosition, emitterSpeed,
                randomGenerator,
                5,
                2,
                GenerateRandomParticle);

            //engine.AddParticle(emitter);

            var attractorPosition = new MatrixCoords(10, 3);
            var attractor = new ParticleAttractor(
                attractorPosition,
                new MatrixCoords(0, 0),
                1);

            var attractorPosition2 = new MatrixCoords(10, 13);
            var attractor2 = new ParticleAttractor(
                attractorPosition2,
                new MatrixCoords(0, 0),
                3);
            //engine.AddParticle(attractor);
            //engine.AddParticle(attractor2);
        }

        static Particle GenerateRandomParticle(ParticleEmitter emitterParameter)
        {
            MatrixCoords particlePos = emitterParameter.Position;

            int particleRowSpeed = emitterParameter.RandomGenerator.Next(emitterParameter.MinSpeedCoord, emitterParameter.MaxSpeedCoord + 1);
            int particleColSpeed = emitterParameter.RandomGenerator.Next(emitterParameter.MinSpeedCoord, emitterParameter.MaxSpeedCoord + 1);

            MatrixCoords particleSpeed = new MatrixCoords(particleRowSpeed, particleColSpeed);

            Particle generated = null;

            int particleTypeIndex = emitterParameter.RandomGenerator.Next(0, 2);
            switch (particleTypeIndex)
            {
                case 0:
                    generated = new Particle(particlePos, particleSpeed);
                    break;
                case 1:
                    uint lifespan = (uint)emitterParameter.RandomGenerator.Next(8);
                    generated = new DyingParticle(particlePos, particleSpeed, lifespan);
                    break;
                default:
                    throw new Exception("No such particle for this particleTypeIndex");
                    break;
            }
            return generated;
        }
    }
}