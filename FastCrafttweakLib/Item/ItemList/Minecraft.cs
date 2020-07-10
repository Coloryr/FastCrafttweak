using System;
using System.Collections.Generic;
using System.Text;

namespace FastCrafttweakLib.Item.ItemList
{
    class Minecraft : IListItem
    {
        private const string Local = "pack://application:,,,/Resource/Minecraft/Texture/";
        public static Dictionary<string, ItemObj> MinecraftList = new Dictionary<string, ItemObj>();

        public void Init()
        {

        }
    }
}
