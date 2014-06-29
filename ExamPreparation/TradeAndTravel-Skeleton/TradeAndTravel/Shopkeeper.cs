namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Shopkeeper : Person, IShopkeeper
    {
        public Shopkeeper(string name, Location location) : base(name, location)
        {
        }

        public virtual int CalculateSellingPrice(Item item)
        {
            return item.Value;
        }

        public virtual int CalculateBuyingPrice(Item item)
        {
            return item.Value / 2;
        }
    }
}