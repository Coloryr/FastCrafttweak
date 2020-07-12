using FastCrafttweakLib.Craft.CraftSave;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastCrafttweakLib.Craft
{
    public class CraftInit
    {
        public static void Init()
        {
            new MinecraftSave().Init();
        }
    }
}
