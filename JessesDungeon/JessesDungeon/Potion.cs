using System;
using System.Collections.Generic;
using System.Text;

namespace JessesDungeon
{
    struct Potion
    {
        public string Name;
        public int Potency;
        public string Description;

        public Potion(string aName, int aPotency, string aDescription)
        {
            Name = aName;
            Potency = aPotency;
            Description = aDescription;
        }
    }
}
