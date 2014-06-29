namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Traveller : Person, ITraveller
    {
        public Traveller(string name, Location location) : base(name, location)
        {
        }

        public virtual void TravelTo(Location location)
        {
            this.Location = location;
        }
    }
}