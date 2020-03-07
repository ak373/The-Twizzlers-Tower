using System;
using System.Collections.Generic;
using System.Text;

namespace JessesDungeon
{
    struct Item
    {
        public string Name;
        public string Description;

        public Item(string aName, string aDescription)
        {
            Name = aName;
            Description = aDescription;
        }
    }
}
