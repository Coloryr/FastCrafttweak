using System.Collections.Generic;

namespace FastCrafttweakLib.Item
{
    public class ItemObj
    {
        public string Name { get; set; }
        public string Texture { get; set; }
        public string BlockID { get; set; }
        public List<string> OredictList { get; set; }
        public Dictionary<string, string> NBTList { get; set; }
        public ListName ListName { get; set; }
        public int Count { get; set; } = 1;
    }
    public enum ListName
    {
        Minecraft
    }
}
