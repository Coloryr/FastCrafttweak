using FastCrafttweakLib.Item;

namespace FastCrafttweakLib.Craft
{
    public class CraftObj
    {
        public string Name { get; set; }
        public ItemObj[] Inputs { get; set; }
        public ItemObj Output { get; set; }
        public CraftListType ListType { get; set; }

        public CraftObj(string Name, ItemObj[] Inputs, ItemObj Output, CraftListType Type)
        {
            this.Name = Name;
            this.Inputs = Inputs;
            this.Output = Output;
            this.ListType = Type;
        }
    }
    public enum CraftListType
    {
        CraftingTable, Furnace
    }
}
