namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Town : Location
    {
        public Town(string name) : base(name, LocationType.Town)
        {
        }
    }
}