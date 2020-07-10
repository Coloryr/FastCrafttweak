using System;
using System.Collections.Generic;
using System.Text;

namespace FastCrafttweakLib.Craft.CraftList
{
    class Furnace : CraftObj
    {
        public Furnace(string[] Inputs, string Output) : base("Furnace", "", Inputs, Output)
        {
            
        }
    }
    class Fuel
    { 
        public string Name { get; set; }
    }
}
