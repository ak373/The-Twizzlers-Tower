using System;
using System.Collections.Generic;
using System.Text;

namespace JessesDungeon
{
    struct Weapon
    {
        public string Name;
        public int Damage;
        public double CritMultiplier;
        public int ToHitMod;
        public bool OneHanded;
        public bool Unlocked;
        public int Price;
        public string Description;

        public Weapon(string aName, int aDamage, double aCritMultiplier, int aToHitMod, bool aOneHanded, bool aUnlocked, int aPrice, string aDescription)
        {
            Name = aName;
            Damage = aDamage;
            CritMultiplier = aCritMultiplier;
            ToHitMod = aToHitMod;
            OneHanded = aOneHanded;
            Unlocked = aUnlocked;
            Price = aPrice;
            Description = aDescription;
        }
    }
}
