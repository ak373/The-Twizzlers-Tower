using System;
using System.Collections.Generic;
using System.Text;

namespace JessesDungeon
{
    struct Shield
    {
        public string Name;
        public int ArmorClass;
        public double CritResist;
        public bool Unlocked;
        public int Price;
        public string Description;

        public Shield(string aName, int aArmorClass, double aCritResist, bool aUnlocked, int aPrice, string aDescription)
        {
            Name = aName;
            ArmorClass = aArmorClass;
            CritResist = aCritResist;
            Unlocked = aUnlocked;
            Price = aPrice;
            Description = aDescription;
        }
    }
}
