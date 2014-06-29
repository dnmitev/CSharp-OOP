namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public interface IShopkeeper
    {
        int CalculateSellingPrice(Item item);

        int CalculateBuyingPrice(Item item);
    }
}