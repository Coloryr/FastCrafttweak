using FastCrafttweakLib.Item;

namespace FastCrafttweakLib.Craft.CraftList
{
    public class CraftingTable : CraftObj
    {
        public CraftType CraftType { get; set; }
        public CraftingTable(ItemObj[] Inputs, ItemObj Output, CraftType type = CraftType.Shaped) : base("CraftingTable", Inputs, Output, CraftListType.CraftingTable)
        {
            CraftType = type;
        }

        public CraftingTable() : base("CraftingTable", new ItemObj[9], null, CraftListType.CraftingTable)
        {
        }
    }
    public enum CraftType
    {
        Shaped, Shapeless
    }
}
