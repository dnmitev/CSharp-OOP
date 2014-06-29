namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Armor : Item
    {
        private const int GeneralArmorValue = 5;

        public Armor(string name, Location location = null) : base(name, Armor.GeneralArmorValue, ItemType.Armor, location)
        {
        }
    }
}