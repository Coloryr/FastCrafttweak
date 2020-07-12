using FastCrafttweakLib.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastCrafttweakLib.Craft.CraftList
{
    class Furnace : CraftObj
    {
        public Furnace(ItemObj[] Inputs, ItemObj Output) : base("Furnace", Inputs, Output, CraftListType.Furnace)
        {
            
        }
        public Furnace() : base("Furnace", new ItemObj[1], null, CraftListType.Furnace)
        { 
            
        }
    }
    class Fuel
    { 
        public string Name { get; set; }

        public int Time { get; set; }
    }
}
