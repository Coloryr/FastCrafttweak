using FastCrafttweakLib.Craft.CraftList;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastCrafttweakLib.Craft.CraftSave
{
    class MinecraftSave : ISave
    {
        public static Dictionary<string, CraftingTable> CraftingTableList = new Dictionary<string, CraftingTable>();
        public static Dictionary<string, Furnace> FurnaceList = new Dictionary<string, Furnace>();

        public void Init()
        { 
            
        }
    }
}
