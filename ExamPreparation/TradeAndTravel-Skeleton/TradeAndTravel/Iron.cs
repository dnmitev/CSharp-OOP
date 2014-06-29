namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Iron : Item
    {
        private const int GeneralIronValue = 3;

        public Iron(string ironName, Location location = null) : base(ironName, GeneralIronValue, ItemType.Iron,location)
        {
        }
    }
}