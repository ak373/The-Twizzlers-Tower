using System;
using System.Collections.Generic;
using System.Text;

namespace JessesDungeon
{
    struct Armor
    {
        public string Name;
        public int DamageReduction;
        public double CritResist;
        public bool Unlocked;
        public int Price;
        public string Description;

        public Armor(string aName, int aDamageReduction, double aCritResist, bool aUnlocked, int aPrice, string aDescription)
        {
            Name = aName;
            DamageReduction = aDamageReduction;
            CritResist = aCritResist;
            Unlocked = aUnlocked;
            Price = aPrice;
            Description = aDescription;
        }
        

        
    }
}
