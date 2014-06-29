namespace TradeAndTravel
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var engine = new Engine(new AdvanceInteractionManager());
            engine.Start();
        }
    }
}