namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Wood : Item
    {
        private const int GeneralWoodValue = 2;

        public Wood(string woodName, Location location = null) : base(woodName, GeneralWoodValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            if (interaction == "drop")
            {
                if (this.Value > 0)
                {
                    this.Value--;
                }
            }

            base.UpdateWithInteraction(interaction);
        }
    }
}