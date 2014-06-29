namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public interface IGatheringLocation
    {
        ItemType GatheredType { get; }

        ItemType RequiredItem { get; }

        Item ProduceItem(string name);
    }
}