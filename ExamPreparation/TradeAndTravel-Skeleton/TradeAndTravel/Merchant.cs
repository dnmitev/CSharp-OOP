namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Merchant : Shopkeeper, ITraveller
    {
        public Merchant(string name, Location location = null) : base(name, location)
        {
        }

        public void TravelTo(Location location)
        {
            this.Location = location;
        }
    }
}