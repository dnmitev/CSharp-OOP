namespace TradeAndTravel
{
    using System;
    using System.Linq;

    public class Weapon : Item
    {
        private const int GeneralWeaponValue = 10;

        public Weapon(string weaponName, Location location = null) : base(weaponName, GeneralWeaponValue, ItemType.Weapon)
        {
        }
    }
}